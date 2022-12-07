using DataLayer;
using ExternalLibraries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {

    

    public class Payment : IActiveRecord<Payment> {
        private readonly string connectionString;
        private const string INSERT = "INSERT INTO payment (rental_or_order, payment_method, date, amount) VALUES (@choice, @method, @date, @amount)";
        private const string GET_LAST_ID = "SELECT TOP 1 id FROM payment ORDER BY id DESC";
        private const string REMOVE_PAYMENT = "DELETE FROM payment WHERE id = @id";
        private const string SELECT_ID = "SELECT id, payment_method, amount FROM payment WHERE id = @id";
        private const string UPDATE_PAYMENT = "UPDATE payment SET payment_method = @method, rental_or_order = @rentor, date = @date, amount = @amount WHERE id = @id";
        public enum PaymentMethodEnum {
            CARD,
            CASH,
            PAYPAL,
            TRANSFER
        };

        public enum RentalOrder {
            RENTAL,
            ORDER
        };
        public int Id { get; set; }
        public int Amount { get; private set; }
        public DateTime Date { get; private set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public RentalOrder ItemPayedFor { get; set; }
        private bool Completed { get; set; }

        private string GetEnumString(PaymentMethodEnum method) {
            if (method == Payment.PaymentMethodEnum.CARD) return "Paypal";
            else if (method == Payment.PaymentMethodEnum.CASH) return "Cash";
            else if (method == Payment.PaymentMethodEnum.TRANSFER) return "Transfer";
            else return "card";
        }
        private static PaymentMethodEnum GetStringEnum(string method) {
            if (method == "Paypal") return Payment.PaymentMethodEnum.CARD;
            else if (method == "Cash") return Payment.PaymentMethodEnum.CASH;
            else if (method == "Transfer") return Payment.PaymentMethodEnum.TRANSFER;
            else return PaymentMethodEnum.CARD;
        }


        private string GetEnumString(RentalOrder method) {
            if (method == RentalOrder.RENTAL) return "Rental";
            else return "Order";
        }

        public Payment(int amount, PaymentMethodEnum paymentMethod, RentalOrder itemPayedFor, int id = -1) {
            connectionString = DatabaseConnector.GetBuilder().ConnectionString;
            Id = GetLastId();
            Amount = amount;
            Date = DateTime.Now;
            PaymentMethod = paymentMethod;
            ItemPayedFor = itemPayedFor;
            Completed = Verify();
        }

        //payment gw stub
        private bool Verify() {

            return PaymentGateway.PaymentGW(this.Amount);
        }

        private int GetLastId() {
            
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(GET_LAST_ID, conn)) {
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows) {
                        return (int)reader[0] + 1;
                    }
                    else return 1;
                }
            }
        }

        public static Payment Find(int id) {
            using (SqlConnection conn = new SqlConnection(DatabaseConnector.GetBuilder().ConnectionString)) {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(SELECT_ID, conn)) {
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    reader.Read();
                    if (reader.HasRows) {
                        return new Payment(Int32.Parse(reader[2].ToString()), GetStringEnum(reader[1].ToString()), RentalOrder.RENTAL, Int32.Parse(reader[0].ToString()));
                    }
                    else return null;
                }
            }
        }

        public void Delete(out string msg) {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(REMOVE_PAYMENT, conn)) {
                    cmd.Parameters.AddWithValue("@id", Id);

                    msg = "deleted payment";
                    Logger.Log(cmd.ExecuteNonQuery() + " Delete payment");
                }
            }
        }

        
        public void Insert(out string msg) {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(INSERT, conn)) {
                    
                    cmd.Parameters.AddWithValue("@choice", GetEnumString(this.ItemPayedFor));
                    cmd.Parameters.AddWithValue("@method", GetEnumString(this.PaymentMethod));
                    cmd.Parameters.AddWithValue("@date", Date);
                    cmd.Parameters.AddWithValue("@amount", Amount);

                    msg = "Successfully created payment";
                    Logger.Log(cmd.ExecuteNonQuery() + " Insert payment");
                }
            }
        }

        public void Update(out string msg) {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(UPDATE_PAYMENT, conn)) {
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.Parameters.AddWithValue("@method", GetEnumString(PaymentMethod));
                    cmd.Parameters.AddWithValue("@rentor", GetEnumString(ItemPayedFor));
                    cmd.Parameters.AddWithValue("@date", Date);
                    cmd.Parameters.AddWithValue("@amount", Amount);


                    msg = "updated payment";
                    Logger.Log(cmd.ExecuteNonQuery() + " Update payment");
                }
            }
        }
    }
}
