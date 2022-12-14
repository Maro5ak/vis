using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExternalLibraries;
using System.Net.Mail;

namespace BusinessLayer {
    public class User : IPerson, IActiveRecord<User>{
        private const string SELECT_LAST_ID = "SELECT TOP 1 id FROM customer ORDER BY id DESC";
        private const string SELECT_VALIDATION = "SELECT id, password, isAdmin FROM customer WHERE email = @email";

        public string Email { get; set; }
        public string Password { get; set; }
        public User() { }

        public User(string email, string password) {
            Email = email;
            Password = Utils.GetHashDataString(password);
        }
        private bool EmailFormatCheck(string email, out string msg) {
            try {
                email = new MailAddress(email).Address;
                msg = string.Empty;
            }
            catch (ArgumentException) {
                msg = "Empty text box Detected!";
                return false;
            }
            catch (FormatException){
                msg = "Invalid email format!";
                return false;
            }

            return true;
        }
        public bool Validate(out int id, out string errorMsg) {
            id = -1;
            errorMsg = string.Empty;
            if (!EmailFormatCheck(this.Email, out errorMsg)) return false;
            using (SqlConnection conn = new SqlConnection(DatabaseConnector.GetBuilder().ConnectionString)) {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(SELECT_VALIDATION, conn)) {
                    cmd.Parameters.AddWithValue("@email", Email);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows) {
                        id = (int)reader[0];
                        if(DBNull.Value != reader[1] && Password != (string)reader[1]) {
                            errorMsg = "Incorrect Email or Password";
                            return false;
                        }
                        if (DBNull.Value != reader[2] && (string)reader[2] == "1") {
                            Runtime.privilegedMode = true;
                        }
                        Logger.Log(errorMsg);
                        return true;
                    }
                }
            }
            errorMsg = "Incorrect Email or Password!";
            return false;
        }

        public virtual void Delete(out string msg) {
            msg = "this should not have happened";
            return;
        }

        public virtual void Insert(out string msg) {
            msg = "this should not have happened";
            return;
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

        public bool Register(string firstName, string lastName, string email, string password, int phone, string address, out Customer registeredCustomer, out string msg) {
            if(!EmailFormatCheck(email, out msg)) {
                registeredCustomer = null;
                return false;
            }
            registeredCustomer = new Customer(GetLastIdUsed() + 1, firstName, lastName, email, phone, Utils.GetHashDataString(password), address);
            registeredCustomer.Insert(out string msgOut);
            Logger.Log(msgOut);
            return true;
        }

        public virtual void Update(out string msg) {
            msg = "this should not have happened";
            return;
        }
    }
}
