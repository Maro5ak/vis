using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer {
    public class Cart {
        public static List<ICart> Items = new List<ICart>();
        public static List<CartItem> CartItems = new List<CartItem>();
        public static Customer Customer { get; set; }
        
        public static void Add(ICart item) {
            
            Items.Add(item);
        }
        public static void Add(CartItem item) {
            CartItems.Add(item);
        }
        public static int SumPrices() {
            int res = 0;
            foreach(ICart i in Items) {
                res += i.SumPrices();
            }

            res += SumDeposits();

            return res;
        }

        public static int SumDeposits() {
            int res = 0;
            foreach(ICart i in Items) {
                if (i is Rental) res += (i as Rental).Instrument.Deposit;
            }

            return res;
        }

        public static int GetOrderId() {
            return OrderDataGW.GetLastOrder();
        }
    }
}
