using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemDomain
{
    public abstract class MyAppliance
    {
        public string ItemNumber { get; protected set; }
        public string Brand { get; protected set; }
        public int Quantity { get; set; }
        public int Wattage { get; protected set; }
        public string Color { get; protected set; }
        public double Price { get; protected set; }

        public override string ToString() =>
            $"Item Number: {ItemNumber}\n + Brand : {Brand}\n + Quantity: {Quantity}\n + Wattage: {Wattage}\n + Color: {Color}\n + Price: {Price}";
    }
}
