using ExternalLibraries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer {
    public class OrderDataGW {
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

        public static List<string> GetOrdersForUser(int id) {
            string query = "SELECT o.id, i.name, i.instrument_type, i.manufacturer, p.amount, p.date\n" +
                "FROM \"order\" o\n" +
                "JOIN customer c ON o.customer_id = c.id\n" +
                "JOIN ordered_items oi ON o.id = oi.order_id\n" +
                "JOIN instrument i ON oi.instrument_id = i.id\n" +
                "JOIN payment p ON o.payment_id = p.id\n" +
                "WHERE c.id = @id";
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<string> data = new List<string>();
                    while (reader.Read()) {
                        StringBuilder sb = new StringBuilder();

                        sb.Append(reader[0] + " | ");
                        sb.Append(reader[2] + " ");
                        sb.Append(reader[3] + " ");
                        sb.Append(reader[1] + " | ");
                        sb.Append("$" + reader[4] + " ");
                        sb.Append(reader[5]);

                        data.Add(sb.ToString());
                    }
                    return data;
                }
                
            }
        }
    }
}
