using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemDomain
{
    public class Vacuums : MyAppliance
    {
        
            public string Grade { get; }
            public int BatteryVoltage { get; }

            public override string ToString()
                => base.ToString() +
                $"Grade: {Grade}\n + Battery voltage: {BatteryVoltage}";

    }
}

