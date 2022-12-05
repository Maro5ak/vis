using ExternalLibraries;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer {
    public class OrderTransactionScript {
        private static readonly string connectionString = DatabaseConnector.GetBuilder().ConnectionString;
        public static int GetLastOrder() {
            string query = "SELECT TOP 1 id FROM \"order\" ORDER BY id DESC";
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn)) {
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows) {
                        return (int)reader[0];
                    }
                    else return 1;
                }
            }
        }

        public static void InsertOrder(int customerId, int paymentId, string address) {
            string query = "INSERT INTO \"order\" (customer_id, address, payment_id) VALUES (@customerId, @address, @paymentId)";
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@paymentId", paymentId);

                    Logger.Log(cmd.ExecuteNonQuery() + " Insert into order");
                }
            }
        }

        public static void InsertOrderItems(int orderId, int instrumentId) {
            string query = "INSERT INTO ordered_items (order_id, instrument_id) VALUES (@orderId, @instrumentId)";
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    cmd.Parameters.AddWithValue("@instrumentId", instrumentId);

                    Logger.Log(cmd.ExecuteNonQuery() + " Insert into ordered_items");
                }
            }
        }

        public static void RemoveOrder(int customerId, int paymentId, string address) {
            string query = "DELETE FROM \"order\" WHERE customer_id = @customerId AND address = @address AND payment_id = @paymentId)";
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@paymentId", paymentId);

                    Logger.Log(cmd.ExecuteNonQuery() + " Delete from order");
                }
            }
        }
    }
}
