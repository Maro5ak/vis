using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalLibraries {
    public class Logger {
        public static void Log<T>(T msg) {
            string message = $"[{DateTime.Now}]: {msg}\n";
            File.AppendAllText(@"C:\Users\maros\source\repos\VIS\vis\ExternalLibraries\Log.txt", message);
        }
    }
}
