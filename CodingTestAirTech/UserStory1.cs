using System;

namespace CodingTestAirTech
{
   public class UserStory1
   {
        public void printFlightDetails()
        {
            var flights = FlightSceduleService.GetFlightsSchedules();

            foreach(var flight in flights)
            {
                Console.WriteLine("Flight: {0} , departure: {1}, arrival: {2}, day: {3}", flight.FlightId, flight.DepatureAirport, flight.ArrivalAirport, flight.Day);
            }
        }
   }
}
