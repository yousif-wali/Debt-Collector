using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtCalculator.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Date { get; set; }
        public int Balance { get; set; }
        public Person() { }
        public Person(string name, string CurrentDate, int balance, string phone)
        {
            Name = name;
            Phone = phone;
            Date = CurrentDate;
            Balance = balance;
        }
        public Person(int id, string name, string CurrentDate, int balance, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Date = CurrentDate;
            Balance = balance;
        }
    }

}
