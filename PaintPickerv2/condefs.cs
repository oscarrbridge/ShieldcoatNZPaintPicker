using FluentFTP;
using System;
using System.Data.OleDb;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace PaintPickerConnections
{
    public class Connection
    {
        public static OleDbConnection connection;

        // Constructor to set the connection string
        static Connection()
        {
            // Get the current working directory of the executable
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Specify the filename for the temporary database file
            string localDatabaseFileName = "tintformulas-update.accdb";

            // Construct the full path to the local downloaded file
            string localDatabasePath = Path.Combine(currentDirectory, localDatabaseFileName);

            // Construct the connection string
            string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={localDatabasePath};Jet OLEDB:Database Password=7;";

            connection = new OleDbConnection(connectionString);
        }

        public class ConnectionV
        {
            public static string ConnectionString { get; private set; }

            public static OleDbConnection GetConnection()
            {
                if (string.IsNullOrEmpty(ConnectionString))
                {
                    // Get the current working directory of the executable
                    string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

                    // Specify the filename for the temporary database file
                    string localDatabaseFileName = "tintformulas-update.accdb";

                    // Construct the full path to the local downloaded file
                    string localDatabasePath = Path.Combine(currentDirectory, localDatabaseFileName);

                    // Construct the connection string
                    ConnectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={localDatabasePath};Jet OLEDB:Database Password=7;";
                }

                return new OleDbConnection(ConnectionString);
            }
        }

        public class BatchTable
        {
            // Create a dictionary that maps type names to BindingSource property names
            public static Dictionary<string, string> batch_dbdict;

            // Constructor to set the connection string
            static BatchTable()
            {

                // Create a dictionary that maps type names to BindingSource property names
                batch_dbdict = new Dictionary<string, string>
            {
                { "Shieldcoat (Paint)",     "Shieldcoat_Range_Paint" },
                { "Shieldcoat (Basecoat)",  "Shieldcoat_Range_Basecoat" },
                { "Shieldcoat (Pointing)",  "Shieldcoat_Range_Pointing" },
                { "Shieldcoat (Bases)",     "Shieldcoat_Range_Paint" },
                { "Coloursteel",            "Coloursteel_Range_Paint" },
                { "Colourbond",             "Colourbond_Range_Paint" },
                { "Monier",                 "Monier_Range_Paint" },
                { "Resene",                 "Resene_Range_Paint" }
            };

            }

        }

        public class BucketTable
        {
            // Create a dictionary that maps type names to BindingSource property names
            public static Dictionary<string, string> bucket_dbdict;

            // Constructor to set the connection string
            static BucketTable()
            {

                // Create a dictionary that maps type names to BindingSource property names
                bucket_dbdict = new Dictionary<string, string>
            {
                { "Shieldcoat (Paint)",     "Shieldcoat_Range_Paint" },
                { "Shieldcoat (Basecoat)",  "Shieldcoat_Range_Basecoat" },
                { "Shieldcoat (Pointing)",  "Shieldcoat_Range_Pointing" },
                { "Coloursteel",            "Coloursteel_Range_Paint" },
                { "Colourbond",             "Colourbond_Range_Paint" },
                { "Monier",                 "Monier_Range_Paint" },
                { "Resene",                 "Resene_Range_Paint" }
            };

            }

        }
    }
}


