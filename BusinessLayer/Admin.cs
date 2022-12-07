using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {
    public class Admin : Customer, IPerson, IActiveRecord<Admin> {
        public bool IsAdmin { get; set; }
        public Admin(int id) : base(id) {
            IsAdmin = true;
        }
        public Admin(int id, string firstname, string lastname, string email, int phone, string password, string address, bool isAdmin) : base(id, firstname, lastname, email, phone, password, address) {
            IsAdmin = isAdmin;
        }


    }
}
