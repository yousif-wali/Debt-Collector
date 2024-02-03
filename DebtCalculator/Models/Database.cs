using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace DebtCalculator.Models
{

    public static class Database
    {
        private static string dbFileName = "MyDatabase.sqlite";
        private static string dbPath = Path.Combine(Environment.CurrentDirectory, dbFileName);
        private static string connectionString = $"Data Source={dbPath};Version=3;";

        // Call this method at the start of your application to ensure the database and required table exists
        public static void InitializeDatabase()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbFileName);
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string sql = "CREATE TABLE IF NOT EXISTS Customers (Id INTEGER PRIMARY KEY, Name TEXT, Phone TEXT, Address TEXT, Balance INTEGER)";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // Example method to add a new row to the SampleTable
        public static void InsertData(string name, string phone, string address, int balance)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Customers (Name, Phone, Address, Balance) VALUES (@Name, @Phone, @Address, @Balance)";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Balance", balance);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Example method to retrieve data from the SampleTable
        public static Person[] GetData()
        {
            var peopleList = new List<Person>();

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT * FROM Customers", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        peopleList.Add(new Person
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Address = reader["Address"].ToString(),
                            Balance = Convert.ToInt32(reader["Balance"])
                        });
                    }
                }
            }

            return peopleList.ToArray();
        }
    }

}
