using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class PartTime : Employee
    {
        public double HourlyRate { get; }
        public double MonthlyRate { get; }

        public PartTime(string id, string name, string sin, double hourlyRate, double workHours) : base(id, name, sin)
        {
            HourlyRate = hourlyRate;
            MonthlyRate = workHours;
        }
        public override double WeeklyPay()
        {
            return HourlyRate * MonthlyRate;
        }
    }
}


