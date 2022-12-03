using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {
    public class Rental {
        public Instrument Instrument { get; set; }
        public Customer Customer { get; set; }
        public Payment Payment { get; set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
        public bool Penalty { get; private set; }

        public Rental(Instrument instrument, Customer customer, Payment payment, DateTime startTime) {
            Instrument = instrument;
            Customer = customer;
            Payment = payment;
            StartTime = startTime;
            EndTime = startTime.AddMonths(1);
            Penalty = false;
        }

        public void createRental() {

        }

        public void cancelRental() {

        }
        public void extendRetunTime(int month) {

        }
        public void returnRental() {

        }
    }
}
