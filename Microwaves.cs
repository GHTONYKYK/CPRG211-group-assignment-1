using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemDomain
{
    public class Microwaves : MyAppliance
    { 
            public double Capacity { get; }
            public string RoomType { get; }
            public new int ItemNumber { get; }
            public new string Brand { get; }
            public override string ToString()
            => base.ToString() +
            $"Capacity: {Capacity}\n + Room Type: {RoomType}\n + Item Number: {ItemNumber}\n + Brand: {Brand}";
             
    }
}
