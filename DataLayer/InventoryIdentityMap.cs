using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataLayer {
    
    public class InventoryIdentityMap {
        private const string SELECT_QUERY = "SELECT i.id, i.instrument_type, i.manufacturer, i.name, i.description, i.price_buy, i.price_rent, i.deposit, i.quantity FROM instrument i WHERE i.id = @id";
        private const string SELECT_COUNT = "SELECT COUNT(id) FROM instrument";
        private readonly string connectionString;
        private Dictionary<int, DataRow> inventoryMap = new Dictionary<int, DataRow>();

        public InventoryIdentityMap() {
            connectionString = DatabaseConnector.GetBuilder().ConnectionString;
        }

        public DataRow Get(int id) {
            foreach(var key in inventoryMap) {
                if (key.Key == id) return key.Value;
            }
            return null;
        }

        public DataRow Find(int id) {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter()) {
                    DataTable table = new DataTable();
                    using (SqlCommand cmd = new SqlCommand(SELECT_QUERY, conn)) {
                        cmd.Parameters.AddWithValue("@id", id);
                        adapter.SelectCommand = cmd;

                        adapter.Fill(table);
                        if (table.Rows.Count > 0) {
                            inventoryMap[Convert.ToInt32(table.Rows[0][0])] = table.Rows[0];
                        }

                        if (inventoryMap.ContainsKey(id))
                            return inventoryMap[id];
                        else return null;
                    }
                }
            }
            
        }

        public int GetRows() {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(SELECT_COUNT, conn)) {
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows) {
                        return (int)reader[0];
                    }
                    else return 0;
                }
            }
        }

    }
}
