using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DataLayer;

namespace BusinessLayer {
    public static class Inventory {
        public static Dictionary<int, Instrument> inventoryMap = new Dictionary<int, Instrument>();

        public static void init() {
            int rows = InventoryFinder.GetRows();
            //MUST BE != OTHERWISE THE THING WILL LOOP INFINITELY
            for (int i = 1; inventoryMap.Count != rows; i++) {
                if (inventoryMap.ContainsKey(i)) continue;
                Instrument tmp = InventoryFinder.Find(i);
                
                if (tmp == null) continue;
                
                inventoryMap.Add(i, tmp);
                
            }
        }

        public static void ExportXML(out string path) {
            using (FileStream fs = new FileStream("inventory.xml", FileMode.Create)) {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Instrument>));

                serializer.Serialize(fs, inventoryMap.Values.ToList());
                path = fs.Name;
            }

        }


        public static HashSet<string> GetTypes() {
            HashSet<string> types = new HashSet<string>();

            foreach (Instrument i in inventoryMap.Values) {
                types.Add(i.Type);
            }

            return types; 
        }

        public static List<string> GetInstrumentNames() {
            List<string> names = new List<string>();
            names.Add("0; New");
            foreach (var i in inventoryMap.Values) {
                names.Add(i.Id + "; " + Utils.Concat(i.Manufacturer, i.Name));
            }
            
            return names;
        }
    }
}
