using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {
    public class Instrument : IActiveRecord<Instrument>{
        public int Id { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public int PriceBuy { get; set; }
        public int PriceRent { get; set; }
        public int Deposit { get; set; }
        public bool Rentable { get; private set; }
        
        public Instrument() { }
        public Instrument(int id, string type, string manufacturer, string name, string description, int priceBuy, int priceRent = 0, int deposit = 0, bool rentable = true) {
            Id = id;
            Type = type;
            Manufacturer = manufacturer;
            Name = name;
            Description = description;
            PriceBuy = priceBuy;
            PriceRent = priceRent;
            Deposit = deposit;
            Rentable = rentable;
        }

        public void Delete() {
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
