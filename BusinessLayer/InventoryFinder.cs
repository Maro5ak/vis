using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer {
    public class InventoryFinder {
        static InventoryIdentityMap map = new InventoryIdentityMap();
        public static Instrument Find(int id) {
          
            DataRow data = map.Get(id);
            if (data == null) {
                data = map.Find(id);
                if(data == null) {
                    return null;
                }
            }

            

            if (data[6] == DBNull.Value)
                return new Instrument(id, data[1].ToString(), data[2].ToString(), data[3].ToString(), data[4].ToString(), Convert.ToInt32(data[5]), quantity: Convert.ToInt32(data[8]), rentable: false);
            else
                return new Instrument(id, data[1].ToString(), data[2].ToString(), data[3].ToString(), data[4].ToString(), Convert.ToInt32(data[5]), Convert.ToInt32(data[6]), Convert.ToInt32(data[7]), Convert.ToInt32(data[8]));
        }

        public static int GetRows() {
            return map.GetRows();
        }
    }
}
