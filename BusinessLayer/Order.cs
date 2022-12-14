using DataLayer;
using ExternalLibraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {
    public class Order : ICart{
        public List<Instrument> OrderItems { get; set; }
        public Customer Customer { get; set; }
        public Payment Payment { get; set; }

        public Order(List<Instrument> orderItems, Customer customer, Payment payment = null) {
            OrderItems = orderItems;
            Customer = customer;
            Payment = payment;
        }

        public int SumPrices() {
            int res = 0;
            foreach (var i in OrderItems)
                res += i.PriceBuy;

            return res;
        }


        public void CreateOrder() {
            OrderDataGW.InsertOrder(Customer.Id, Payment.Id, Customer.Address);
            foreach (var i in OrderItems) {
                OrderDataGW.InsertOrderItems(OrderDataGW.GetLastOrder(), i.Id);
                Instrument current = i;
                current.Quantity -= 1;
                current.Update(out string msg);
                Logger.Log(msg);
            }
        }



        public void CancelOrder() {
            OrderDataGW.RemoveOrder(Customer.Id, Payment.Id, Customer.Address);
            Payment.Delete(out string msg);
            Logger.Log(msg);
        }
    }
}
