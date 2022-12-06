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
        private readonly string INSERT = "INSERT INTO payment (rental_or_order, payment_method, date, amount) VALUES (@choice, @method, @date, @amount)";
        private readonly string GET_LAST_ID = "SELECT TOP 1 id FROM payment ORDER BY id DESC";
        private readonly string REMOVE_PAYMENT = "DELETE FROM payment WHERE id = @id";
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

        private string GetEnumString(RentalOrder method) {
            if (method == RentalOrder.RENTAL) return "Rental";
            else return "Order";
        }

        public Payment(int amount, PaymentMethodEnum paymentMethod, RentalOrder itemPayedFor) {
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

        public void Delete() {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(REMOVE_PAYMENT, conn)) {
                    cmd.Parameters.AddWithValue("@id", Id);

                    Logger.Log(cmd.ExecuteNonQuery() + " Delete payment");
                }
            }
        }

        
        public void Insert() {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(INSERT, conn)) {
                    
                    cmd.Parameters.AddWithValue("@choice", GetEnumString(this.ItemPayedFor));
                    cmd.Parameters.AddWithValue("@method", GetEnumString(this.PaymentMethod));
                    cmd.Parameters.AddWithValue("@date", Date);
                    cmd.Parameters.AddWithValue("@amount", Amount);
                    
                    Logger.Log(cmd.ExecuteNonQuery() + " Insert payment");
                }
            }
        }

        public void Update() {
            throw new NotImplementedException();
        }
    }
}
