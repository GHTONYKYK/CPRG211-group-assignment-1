using AssignmentAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAbstract
{
    public class FlightService
    {
        private static readonly List<Flight> flights = new List<Flight>


    {
        new Flight { Number = "AA123", DepartureTime = new DateTime(2024, 7, 15, 10, 0, 0), ArrivalTime = new DateTime(2024, 7, 15, 14, 0, 0), Origin = new Airport { IataCode = "JFK", Name = "John F. Kennedy International" }, Destination = new Airport { IataCode = "LAX", Name = "Los Angeles International" } },
        // Add more flights here...
    };
        
        private static readonly List<Reservation> reservations = new List<Reservation>();

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

        public Reservation MakeReservation(string travelerName, string citizenship, Flight flight)
        {
            if (flight.IsBooked)
            {
                throw new InvalidOperationException("This flight is already booked.");
            }

            flight.BookFlight(); 

            var reservation = new Reservation(flight, travelerName, citizenship);
            reservations.Add(reservation); 

            return reservation;
        }
    }
}
