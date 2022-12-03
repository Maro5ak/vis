using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {
    public class Order{
        public List<Instrument> OrderItems { get; set; }
        public Customer Customer { get; set; }
        public Payment Payment { get; set; }

        public Order(List<Instrument> orderItems, Customer customer, Payment payment) {
            OrderItems = orderItems;
            Customer = customer;
            Payment = payment;
        }

        public void createOrder() {

        }

        public void cancelOrder() {

        }
    }
}
