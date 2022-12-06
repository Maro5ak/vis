using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {
    public class CartItem{
        public Instrument Instrument { get; set; }
        public Payment.RentalOrder RentalOrder { get; set; }

        public CartItem(Instrument instrument, Payment.RentalOrder rentalOrder) {
            Instrument = instrument;
            RentalOrder = rentalOrder;
        }   

        

    }
}
