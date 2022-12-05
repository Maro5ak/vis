using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {
    public class Utils {
        public static byte[] HashData(string data) {
            using (HashAlgorithm hash = SHA256.Create()) {
                return hash.ComputeHash(Encoding.UTF8.GetBytes(data));
            }
        }

        public static string Concat(string a, string b) {
            StringBuilder sb = new StringBuilder();
            sb.Append(a);
            sb.Append(" ");
            sb.Append(b);
            return sb.ToString();
        }
        public static string GetHashDataString(string data) {
            StringBuilder sb = new StringBuilder();
            foreach(byte b in HashData(data)) 
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
    }
}
