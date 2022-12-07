using DataLayer;
using ExternalLibraries;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {
    public class Instrument : IActiveRecord<Instrument>{
        private readonly string connectionString;
        private const string INSERT_INSTRUMENT_ALL = "INSERT INTO instrument (instrument_type, manufacturer, name, description, price_buy, price_rent, deposit, rentable, quantity) VALUES (@type, @manufacturer, @name, @description, @priceBuy, @priceRent, @deposit, @rentable, @quantity)";
        private const string INSERT_INSTRUMENT_PARTIAL = "INSERT INTO instrument (instrument_type, manufacturer, name, description, price_buy, rentable, quantity) VALUES (@type, @manufacturer, @name, @description, @priceBuy, @rentable, @quantity)";
        private const string UPDATE_INSTRUMENT_ALL = "UPDATE instrument SET instrument_type = @type, manufacturer = @manufacturer, name = @name, description = @description, price_buy = @priceBuy, price_rent = @priceRent, deposit = @deposit, rentable = @rentable, quantity = @quantity WHERE id = @id";
        private const string UPDATE_INSTRUMENT_PARITAL = "UPDATE instrument SET instrument_type = @type, manufacturer = @manufacturer, name = @name, description = @description, price_buy = @priceBuy, rentable = @rentable, quantity = @quantity WHERE id = @id";
        public int Id { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public int PriceBuy { get; set; }
        public int PriceRent { get; set; }
        public int Deposit { get; set; }
        public bool Rentable { get; set; }
        public int Quantity { get; set; }

        private Instrument() { }
        
        public Instrument(int id, string type, string manufacturer, string name, string description, int priceBuy, int priceRent = 0, int deposit = 0, int quantity = 0, bool rentable = true) {
            connectionString = DatabaseConnector.GetBuilder().ConnectionString;
            Id = id;
            Type = type;
            Manufacturer = manufacturer;
            Name = name;
            Description = description;
            PriceBuy = priceBuy;
            PriceRent = priceRent;
            Deposit = deposit;
            Rentable = rentable;
            Quantity = quantity;
        }

        public void Delete(out string msg) {
            msg = "this should not have happened (yet)"
        }


        public void Insert(out string msg) {
            bool sanityCheck = true;
            if(Description == String.Empty) { Description = ""; }
            Description.Replace('\n', ' ');
            if (Rentable)
                if (PriceRent < 0 || Deposit < 0) sanityCheck = false;

            if (PriceBuy < 0 || Quantity< 0) sanityCheck = false;
            if (!sanityCheck) {
                msg = "Invalid Data";
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = conn;
                    if (Rentable) { 
                        cmd.CommandText = INSERT_INSTRUMENT_ALL;
                        cmd.Parameters.AddWithValue("@priceRent", PriceRent);
                        cmd.Parameters.AddWithValue("@deposit", Deposit);
                    }
                    else cmd.CommandText = INSERT_INSTRUMENT_PARTIAL;

                    cmd.Parameters.AddWithValue("@type", Type);
                    cmd.Parameters.AddWithValue("@manufacturer", Manufacturer);
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@description", Description);
                    cmd.Parameters.AddWithValue("@priceBuy", PriceBuy);
                    cmd.Parameters.AddWithValue("@rentable", (Rentable ? '1' : '0'));
                    cmd.Parameters.AddWithValue("@quantity", Quantity);

                    msg = "Succesfully Created";
                    Logger.Log(cmd.ExecuteNonQuery());

                }
            }
        }

        public void Update(out string msg) {
            bool sanityCheck = true;
            if (Description == String.Empty) { Description = ""; }
            Description.Replace('\n', ' ');
            if (Rentable)
                if (PriceRent < 0 || Deposit < 0) sanityCheck = false;

            if (PriceBuy < 0 || Quantity < 0) sanityCheck = false;
            if (!sanityCheck) {
                msg = "Invalid Data";
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = conn;
                    if (Rentable) {
                        cmd.CommandText = UPDATE_INSTRUMENT_ALL;

                        cmd.Parameters.AddWithValue("@priceRent", PriceRent);
                        cmd.Parameters.AddWithValue("@deposit", Deposit);
                    }
                    else cmd.CommandText = UPDATE_INSTRUMENT_PARITAL;
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.Parameters.AddWithValue("@type", Type);
                    cmd.Parameters.AddWithValue("@manufacturer", Manufacturer);
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@description", Description);
                    cmd.Parameters.AddWithValue("@priceBuy", PriceBuy);
                    cmd.Parameters.AddWithValue("@rentable", (Rentable ? '1' : '0'));
                    cmd.Parameters.AddWithValue("@quantity", Quantity);

                    msg = "Successfully Updated";
                    Logger.Log(cmd.ExecuteNonQuery() + " Updated rows");

                }
            }
        }

    }
}
