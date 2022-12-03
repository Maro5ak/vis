using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {
    public class Customer : User, IActiveRecord<Customer>{
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public string Address { get; set; }

        public Customer() { }
        public Customer(string firstname, string lastname, string email, string password, string address) {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Address = address;
            Password = Utils.HashData(password);
            Console.WriteLine(Utils.GetHashDataString(password));
        }

        Customer IActiveRecord<Customer>.Find() {
            throw new NotImplementedException();
        }
    }
}
