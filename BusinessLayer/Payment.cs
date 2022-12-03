using ExternalLibraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {
    public class Payment : IActiveRecord<Payment> {
        public enum PaymentMethodEnum {
            CARD,
            CASH,
            PAYPAL,
            TRANSFER
        };

        public enum RentalOrder {
            RENTAL,
            ORDER
        };

        public int Amount { get; private set; }
        public DateTime Date { get; private set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public RentalOrder ItemPayedFor { get; set; }
        private bool Completed { get; set; }

        public Payment(int amount, PaymentMethodEnum paymentMethod, RentalOrder itemPayedFor) {
            Amount = amount;
            Date = DateTime.Now;
            PaymentMethod = paymentMethod;
            ItemPayedFor = itemPayedFor;
            Completed = Verify();
        }

        //payment gw stub
        private bool Verify() {

            return PaymentGateway.PaymentGW(this.Amount);
        }

        public void Delete() {
            throw new NotImplementedException();
        }

        public Payment Find() {
            throw new NotImplementedException();
        }

        public void Insert() {
            throw new NotImplementedException();
        }

        public void Update() {
            throw new NotImplementedException();
        }
    }
}
