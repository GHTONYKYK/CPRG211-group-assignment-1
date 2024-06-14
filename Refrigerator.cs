using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemDomain
{
    public class Refrigerators : MyAppliance
    {
        public int NumberOfDoors { get; }
        public int Height { get; }
        public int Width { get; }
        public override string ToString()
            => base.ToString() +
            $"Number of Doors: {NumberOfDoors}\n + Height: {Height} inches\n + Width: {Width} inches";

    }
}
