﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer {
    public static class Inventory {
        public static Dictionary<int, Instrument> inventoryMap = new Dictionary<int, Instrument>();
        public static InventoryFinder finder;


    }
}
