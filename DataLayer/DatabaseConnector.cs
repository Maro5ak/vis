using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataLayer {
    public static class DatabaseConnector {
        public static SqlConnectionStringBuilder GetBuilder() {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"dbsys.cs.vsb.cz\STUDENT";
            builder.UserID = "pta0057";
            builder.Password = "W4h20NXnqnt9B0k4";
            builder.InitialCatalog = "pta0057";
            return builder;
        }   
    }
}
