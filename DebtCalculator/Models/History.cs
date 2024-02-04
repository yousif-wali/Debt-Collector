using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtCalculator.Models
{
    public class History
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public int Balance { get; set; }

        public History() { }
        public History(int id, string name, string date, int balance)
        {
            Id = id;
            Name = name;
            Date = date;
            Balance = balance;
        }
        public History(string name, string date, int balance)
        {
            Name = name;
            Date = date;
            Balance = balance;
        }
    }
}
