using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer {
    public class Cart {
        public List<ICart> Items { get; set; }
        public Customer Customer { get; set; }
        public Cart(Customer customer) {
            this.Customer = customer;
            Items = new List<ICart>();
            List<Instrument> o1 = new List<Instrument>();
            
            o1.Add(Inventory.inventoryMap[1]);
            o1.Add(Inventory.inventoryMap[5]);

            Rental r = new Rental(Inventory.inventoryMap[8], customer, DateTime.Now);
            Order o = new Order(o1, customer);
            this.Add(o);
            this.Add(r);

        }

        public ICart this[int id] {
            get {
                return Items[id];
            }
        }

        public void Add(ICart item) {
            
            Items.Add(item);
        }

        public int SumPrices() {
            int res = 0;
            foreach(ICart i in Items) {
                res += i.SumPrices();
            }

            res += SumDeposits();

            return res;
        }

        public int SumDeposits() {
            int res = 0;
            foreach(ICart i in Items) {
                if (i is Rental) res += (i as Rental).Instrument.Deposit;
            }

            return res;
        }

        public int GetOrderId() {
            return OrderTransactionScript.GetLastOrder();
        }
    }
}
