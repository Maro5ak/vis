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
    public class RentalTransactionScript {
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
    }
}
