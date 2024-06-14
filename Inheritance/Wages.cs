using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Wages : Employee
    {   
        public double HourlyRate { get; }
        public double WorkHours { get; }

        public Wages(string id, string name, string sin, double hourlyRate, double workHours) : base(id, name, sin)
        {
            HourlyRate = hourlyRate;
            WorkHours = workHours;
        }

        public override double WeeklyPay()
        {
            if (WorkHours > 40)
            {
                return HourlyRate * 40 + HourlyRate * 1.5 * (WorkHours - 40);
            }
            else
            {
                return WeeklyPay();
            }
        }
    }
}
