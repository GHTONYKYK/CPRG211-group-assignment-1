using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    public class FlightService
    {
        // Example list of flights - this would typically come from a database or API
        private static readonly List<Flight> flights = new List<Flight>
    {
        new Flight { Number = "AA123", DepartureTime = new DateTime(2024, 7, 15, 10, 0, 0), ArrivalTime = new DateTime(2024, 7, 15, 14, 0, 0), Origin = new Airport { IataCode = "JFK", Name = "John F. Kennedy International" }, Destination = new Airport { IataCode = "LAX", Name = "Los Angeles International" } },
        // Add more flights here...
    };

        public List<Flight> FindFlights(string originAirport, string destinationAirport, DayOfWeek dayOfWeek)
        {
            var filteredFlights = new List<Flight>();

            foreach (var flight in flights)
            {
                if (flight.Origin.IataCode == originAirport && flight.Destination.IataCode == destinationAirport && flight.DepartureTime.DayOfWeek == dayOfWeek)
                {
                    filteredFlights.Add(flight);
                }
            }

            return filteredFlights;
        }
    }
}
