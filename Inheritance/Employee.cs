using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Employee
    {
        public string ID { get; }
        public string Name { get; }
        public string SIN { get; }


        public Employee(string id, string name, string sin)
        {
            ID = id;
            Name = name;
            SIN = sin;

        }

        public abstract double WeeklyPay();
    }
}
