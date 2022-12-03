using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {
    public class Admin : Customer, IActiveRecord<Admin> {
        public List<Ticket> AssignedTickets { get; set; }
        public Admin(string firstname, string lastname, string email, string password, string address) : base(firstname, lastname, email, password, address) {
        }

        Admin IActiveRecord<Admin>.Find() {
            throw new NotImplementedException();
        }
    }
}
