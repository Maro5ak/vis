using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public Rental(Instrument instrument, Customer customer, DateTime startTime, Payment payment = null) {
            Instrument = instrument;
            Customer = customer;
            Payment = payment;
            StartTime = startTime;
            EndTime = startTime.AddMonths(1);
            Penalty = false;
        }

        public void CreateRental() {
            RentalTransactionScript.InsertRental(StartTime, EndTime, (!Penalty ? '0' : '1'), Customer.Id, Instrument.Id, Customer.Address, Payment.Id);
        }

        public void CancelRental() {

        }
        public void ExtendReturnTime(int month) {

        }
        public void ReturnRental() {

        }

        public int GetLastId() {
            return RentalTransactionScript.GetLastId();
        }

        public int SumPrices() {
            return Instrument.PriceRent * ((EndTime.Year - StartTime.Year) * 12 + EndTime.Month - StartTime.Month);
        }
    }
}
