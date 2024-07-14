using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAbstract
{
    public class Airport
    {
        public string IataCode { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name} ({IataCode})";
        }
    }

    public class Flight
    {
        public string Number { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public Airport Origin { get; set; }
        public Airport Destination { get; set; }
        public bool IsBooked { get; private set; } = false;

        public void BookFlight()
        {
            IsBooked = true;
        }

        public override string ToString()
        {
            return $"Flight {Number} from {Origin} to {Destination}";
        }
    }


}
