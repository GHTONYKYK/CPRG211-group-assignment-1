using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            FlightService flightService = new FlightService();
            List<Flight> flightsFromJFKtoLAXonMonday = flightService.FindFlights("JFK", "LAX", DayOfWeek.Monday);

            Console.WriteLine($"Found {flightsFromJFKtoLAXonMonday.Count} flights:");
            foreach (var flight in flightsFromJFKtoLAXonMonday)
            {
                Console.WriteLine(flight);
            }
        }
    }
