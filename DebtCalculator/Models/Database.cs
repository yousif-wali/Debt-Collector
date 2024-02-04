using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Configuration;
using Dapper;

namespace DebtCalculator.Models
{

    public static class Database
    {
        // Example method to add a new row to the SampleTable
        public static void InsertData(Person person)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadManager()))
            {
                cnn.Execute("INSERT INTO Customer (Name, Phone, Address, Balance) VALUES (@Name, @Phone, @Address, @Balance)", person);
                cnn.Execute("INSERT INTO Transactions (Name, Date, Balance) VALUES (@Name, @Date, @Balance)", new { Name = person.Name, Balance = person.Balance, Date = DateTime.Now.ToString() });
            
            }
        }

        // Example method to retrieve data from the SampleTable
        public static Person[] GetData()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadManager()))
            {
                var output = cnn.Query<Person>("Select * FROM Customer", new DynamicParameters());
                return output.ToArray();
            }
        }
        public static History[] GetHistories()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadManager()))
            {
                var output = cnn.Query<History>("Select * FROM Transactions order by Id desc", new DynamicParameters());
                return output.ToArray();
            }
        }
        public static History[] GetHistories(string name)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadManager()))
            {
                var output = cnn.Query<History>("Select * FROM Transactions WHERE Name = @Name order by Id desc", new { Name = name});
                return output.ToArray();
            }
        }
            public static void DeleteData(int id, string name)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadManager()))
            {
                cnn.Execute("DELETE FROM Customer Where Id = @Id limit 1;", new { Id = id});
                cnn.Execute("DELETE FROM Transactions WHERE Name = @Name", new { Name = name});
            }
        }
        public static IEnumerable<Person> Search(string search)
        {
            using(IDbConnection cnn = new SQLiteConnection(LoadManager()))
            {
                var output = cnn.Query<Person>("SELECT * FROM Customer WHERE Name = @Search OR Phone = @Search OR Address = @Search OR Balance = @Search",
                                new { Search = search });
                return output;
            }
        }
        public static void Update(int id, string name, string phone, string address, int balance)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadManager()))
            {
                
                cnn.Execute("UPDATE Customer SET Name = @Name, Phone = @Phone, Address = @Address, Balance = @Balance WHERE Id = @Id",
                    new { Id = id, Name = name, Phone = phone, Address = address, Balance = balance});
                cnn.Execute("INSERT INTO Transactions (Name, Date, Balance) VALUES (@Name, @Date, @Balance)", new { Name = name, Balance = balance, Date = DateTime.Now.ToString() });

            }
        }
        private static string LoadManager(string Id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[Id].ConnectionString;
        }
    }

}
