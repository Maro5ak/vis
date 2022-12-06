using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ExternalLibraries;

namespace DataLayer {
    public class RentalDataGW {
        private static readonly string connectionString = DatabaseConnector.GetBuilder().ConnectionString;

        public static int GetLastId() {
            string query = "SELECT TOP 1 id FROM rental ORDER BY id DESC";
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
        public static void InsertRental(DateTime startTime, DateTime endTime, char penalty, int customerId, int instrumentId, string address, int paymentId) {
            string query = "INSERT INTO rental (start_date, end_date, penalty, customer_id, instrument_id, address, payment_id) VALUES (@start, @end, @penalty, @customerId, @instrumentId, @address, @paymentId)";
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@start", startTime);
                    cmd.Parameters.AddWithValue("@end", endTime);
                    cmd.Parameters.AddWithValue("@penalty", penalty);
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    cmd.Parameters.AddWithValue("@instrumentId", instrumentId);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@paymentId", paymentId);

                    Logger.Log(cmd.ExecuteNonQuery() + " Insert into rental");
                }
            }
        }

        public static void DeleteRental(DateTime startTime, DateTime endTime, char penalty, int customerId, int instrumentId, string address, int paymentId) {
            string query = "DELETE FROM rental WHERE start_date = @start AND end_date = @end AND penalty = @penalty AND customer_id = @customerId AND instrument_id = @instrumentId AND address = @address AND payment_id = @paymentId)";
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@start", startTime);
                    cmd.Parameters.AddWithValue("@end", endTime);
                    cmd.Parameters.AddWithValue("@penalty", penalty);
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    cmd.Parameters.AddWithValue("@instrumentId", instrumentId);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@paymentId", paymentId);

                    Logger.Log(cmd.ExecuteNonQuery() + " Delete from rental");
                }
            }
        }

        public static List<string> GetOrdersForUser(int id) {
            string query = "SELECT r.id, i.name, i.instrument_type, i.manufacturer, CAST(r.start_date AS DATE), CAST(r.end_date AS DATE) ,p.amount, p.date\n" +
            "FROM rental r\n" +
            "JOIN customer c ON r.customer_id = c.id\n" +
            "JOIN instrument i ON r.instrument_id = i.id\n" +
            "JOIN payment p ON r.payment_id = p.id\n" +
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
                        sb.Append(reader[4] + " - ");
                        sb.Append(reader[5] + " | ");
                        sb.Append("$" + reader[6] + " ");
                        sb.Append(reader[7]);

                        data.Add(sb.ToString());
                    }
                    return data;
                }

            }
        }
    }
}
