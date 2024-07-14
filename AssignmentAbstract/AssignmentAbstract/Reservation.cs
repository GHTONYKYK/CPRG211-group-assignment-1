using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAbstract
{
    public class Reservation
    {
        public string TravelerName { get; set; }
        public string Citizenship { get; set; }
        public Flight Flight { get; set; }

        public Reservation(Flight flight, string travelerName, string citizenship)
        {
            Flight = flight ?? throw new ArgumentNullException(nameof(flight));
            TravelerName = travelerName ?? throw new ArgumentNullException(nameof(travelerName));
            Citizenship = citizenship ?? throw new ArgumentNullException(nameof(citizenship));
        }

        public override string ToString()
        {
            return $"Reservation for {TravelerName} on flight {Flight.Number}";
        }
    }

}
