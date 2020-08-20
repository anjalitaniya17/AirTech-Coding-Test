using System.Collections.Generic;

namespace CodingTestAirTech
{
    public static class AirportCode
    {
        public static readonly string Montreal = "YUL";
        public static readonly string Toronto = "YYZ";
        public static readonly string Calgary = "YYC";
        public static readonly string Vancouver = "YVR";
    }

    public static class FlightSceduleService
    {
        public static List<FlightInformation> GetFlightsSchedules()
        {
            var flights = new List<FlightInformation>();

            flights.Add(new FlightInformation() { Day = 1, DepatureAirport = AirportCode.Montreal, ArrivalAirport = AirportCode.Toronto , FlightId = 1});
            flights.Add(new FlightInformation() { Day = 1, DepatureAirport = AirportCode.Montreal, ArrivalAirport = AirportCode.Calgary, FlightId = 2 });
            flights.Add(new FlightInformation() { Day = 1, DepatureAirport = AirportCode.Montreal, ArrivalAirport = AirportCode.Vancouver, FlightId = 3 });
            flights.Add(new FlightInformation() { Day = 2, DepatureAirport = AirportCode.Montreal, ArrivalAirport = AirportCode.Toronto, FlightId = 4 });
            flights.Add(new FlightInformation() { Day = 2, DepatureAirport = AirportCode.Montreal, ArrivalAirport = AirportCode.Calgary, FlightId = 5 });
            flights.Add(new FlightInformation() { Day = 2, DepatureAirport = AirportCode.Montreal, ArrivalAirport = AirportCode.Vancouver, FlightId = 6 });

            return flights;
        } 
    }
}
