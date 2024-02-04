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
        public string Address { get; set; }
        public int Balance { get; set; }

        public Person(string name, string phone, string address, int balance)
        {
            Name = name;
            Phone = phone;
            Address = address;
            Balance = balance;
        }
    }

}
