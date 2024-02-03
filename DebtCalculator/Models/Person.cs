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
        public required string Name { get; set; }
        public required string Phone { get; set; }
        public required string Address { get; set; }
        public int Balance { get; set; }
    }

}
