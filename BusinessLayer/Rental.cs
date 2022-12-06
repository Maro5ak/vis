using DataLayer;
using ExternalLibraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {
    public class Rental : ICart {
       
        public Instrument Instrument { get; set; }
        public Customer Customer { get; set; }
        public Payment Payment { get; set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
        public bool Penalty { get; private set; }

        public int CalculatePenaltyPrice() {
            return (Instrument.PriceBuy - Instrument.PriceRent);
        }
        
        public int GetRentalUpdatePrice() {
            return this.CalculatePenaltyPrice() - Instrument.Deposit;
        }

        public bool CheckPenaltyAfterUpdate() {
            return DateTime.Now > EndTime;
        }

        public Rental(Instrument instrument, Customer customer, DateTime startTime, Payment payment = null) {
            Instrument = instrument;
            Customer = customer;
            Payment = payment;
            StartTime = startTime;
            EndTime = startTime.AddMonths(1);
            Penalty = false;
        }
        public static Rental GetRental(int id) {
            List<string> data = RentalDataGW.GetRentalById(id);
            Instrument instrument = Inventory.inventoryMap[Int32.Parse(data[0])];
            DateTime startTime = DateTime.Parse(data[1]);
            DateTime endTime = DateTime.Parse(data[2]);
            bool penalty = (data[3] == "0" ? false : true);
            Payment payment = Payment.Find(Int32.Parse(data[4]));
            Rental res = new Rental(instrument, new Customer(Runtime.loggedIn), startTime, payment);
            res.EndTime = endTime;
            res.Penalty = res.CheckPenaltyAfterUpdate();
            return res;
        }

        

        public void CreateRental() {
            RentalDataGW.InsertRental(StartTime, EndTime, (!Penalty ? '0' : '1'), Customer.Id, Instrument.Id, Customer.Address, Payment.Id);
        }

        public void ExtendReturnTime(int id) {
            EndTime = EndTime.AddMonths(1);
           RentalDataGW.ExtendReturnTime(id, EndTime);
        }
        public void ReturnRental() {
            RentalDataGW.DeleteRental(StartTime, EndTime, Penalty ? '1' : '2', Customer.Id, Instrument.Id, Customer.Address, Payment.Id);
        }

        public int GetLastId() {
            return RentalDataGW.GetLastId();
        }

        public int SumPrices() {
            return Instrument.PriceRent * ((EndTime.Year - StartTime.Year) * 12 + EndTime.Month - StartTime.Month);
        }
    }
}
