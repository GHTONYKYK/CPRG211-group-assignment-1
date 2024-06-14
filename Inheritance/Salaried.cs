using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Salaried : Employee
    {
        private const double OvertimeRate = 1.5;
        public Salaried(string id, string name, string sin) : base(id, name, sin)
        {

        }
        public override double WeeklyPay()
        {
            return 0;
        }
    }
}
