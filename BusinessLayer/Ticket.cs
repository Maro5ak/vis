using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {
    public class Ticket : IActiveRecord<Ticket> {

        public string Name { get; set; }
        public string Data { get; set; }
        public bool Resolved { get; set; }

        public void Delete() {
            throw new NotImplementedException();
        }

        public Ticket Find() {
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
