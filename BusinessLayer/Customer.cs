using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DataLayer;
using ExternalLibraries;

namespace BusinessLayer {
    public class Customer : User, IPerson, IActiveRecord<Customer>{
        private readonly string connectionString;
        private const string SELECT_USER = "SELECT id, firstName, lastName, email, phone, password, address FROM customer WHERE id = @id";
        private const string UPDATE_USER = "UPDATE customer SET firstName = @firstName, lastName = @lastName, email = @email, phone = @phone, password = @password, address = @address WHERE id = @id";
        private const string UPDATE_USER_NO_PW = "UPDATE customer SET firstName = @firstName, lastName = @lastName, email = @email, phone = @phone, address = @address WHERE id = @id";
        private const string INSERT_USER = "INSERT INTO customer (firstName, lastName, email, password, phone, address) VALUES (@firstName, @lastName, @email, @password, @phone, @address)";
        public int Id { get; private set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }

        public Customer(int id) {
            using (SqlConnection conn = new SqlConnection(connectionString = DatabaseConnector.GetBuilder().ConnectionString)) {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(SELECT_USER, conn)) {
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows) {
                        Id = id;
                        Firstname = reader.GetString(1);
                        Lastname = reader.GetString(2);
                        Email = reader.GetString(3);
                        Phone = reader.GetInt32(4);
                        Password = reader.GetString(5).ToUpper();
                        Address = reader.GetString(6);
                    }
                }
            }
        }

        
        public Customer(int id, string firstname, string lastname, string email, int phone, string password, string address) : base(email, password){
            connectionString = DatabaseConnector.GetBuilder().ConnectionString;
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Phone = phone;
            Address = address;
        }
        public Customer(int id, string firstname, string lastname, string email, int phone, string address) {
            connectionString = DatabaseConnector.GetBuilder().ConnectionString;
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Phone = phone;
            Address = address;

        }

       
        public override void Insert(out string msg) {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(INSERT_USER, conn)) {
                    cmd.Parameters.AddWithValue("@firstName", Firstname);
                    cmd.Parameters.AddWithValue("@lastName", Lastname);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@password", Password);
                    cmd.Parameters.AddWithValue("@address", Address);
                    cmd.Parameters.AddWithValue("@phone", Phone);

                    msg = "Successfully created new Customer";
                    Logger.Log(cmd.ExecuteNonQuery());
                }
            }
        }
        public override void Update(out string msg) {

            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.CommandText = UPDATE_USER_NO_PW;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.Parameters.AddWithValue("@firstName", Firstname);
                    cmd.Parameters.AddWithValue("@lastName", Lastname);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@address", Address);
                    cmd.Parameters.AddWithValue("@phone", Phone);

                    if (Password != null) {
                        cmd.CommandText = UPDATE_USER;
                        cmd.Parameters.AddWithValue("@password", Password);

                    }
                    msg = "Successfully updated Customer";
                    Logger.Log(cmd.ExecuteNonQuery() + " Updated customer");
                }                    
                
            }
        }
    }
}
