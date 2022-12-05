using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExternalLibraries;

namespace BusinessLayer {
    public class User : IPerson, IActiveRecord<User>{
        private const string SELECT_LAST_ID = "SELECT TOP 1 id FROM customer ORDER BY id DESC";
        private const string SELECT_VALIDATION = "SELECT id, isAdmin FROM customer WHERE email = @email AND password = @password";

        public string Email { get; set; }
        public string Password { get; set; }
        public User() { }

        public User(string email, string password) {
            Email = email;
            Password = Utils.GetHashDataString(password);
        }

        public bool Validate(out int id) {
            using (SqlConnection conn = new SqlConnection(DatabaseConnector.GetBuilder().ConnectionString)) {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(SELECT_VALIDATION, conn)) {
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@password", Password);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows) {
                        id = (int)reader[0];
                        if (DBNull.Value != reader[1] && (string)reader[1] == "1") {
                            Runtime.privilegedMode = true;
                        }
                        return true;
                    }
                }
            }
            id = -1;
            return false;
        }

        public virtual void Delete() {
        }

        public virtual void Insert() {
        }
        private int GetLastIdUsed() {
            using (SqlConnection conn = new SqlConnection(DatabaseConnector.GetBuilder().ConnectionString)) {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(SELECT_LAST_ID, conn)) {
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    return (int)reader[0];
                }
            }
        }

        public void Register(string firstName, string lastName, string email, string password, int phone, string address, out Customer registeredCustomer) {
            registeredCustomer = new Customer(GetLastIdUsed() + 1, firstName, lastName, email, phone, Utils.GetHashDataString(password), address);
            registeredCustomer.Insert();
        }

        public virtual void Update() {
        }
    }
}
