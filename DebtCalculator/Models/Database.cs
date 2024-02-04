﻿using System.Data.SQLite;
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
        public static void DeleteData(Person person)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadManager()))
            {
                cnn.Execute("DELETE FROM Customer Where Name = @Name and Phone = @Phone and Address = @Address and Balance = @Balance limit 1;", person);
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
        private static string LoadManager(string Id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[Id].ConnectionString;
        }
    }

}
