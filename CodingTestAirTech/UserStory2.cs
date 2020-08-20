using System;

namespace CodingTestAirTech
{
    public class UserStory2
    {
        public int CapacityOfFlight { get; set; }

        public UserStory2(int capacityOfFlight)
        {
            CapacityOfFlight = capacityOfFlight;
        }

        public void PrintOrders()
        {
            var finalOrders = OrderService.GetOrderDetails(CapacityOfFlight);
          
            Console.WriteLine("======================================================");
            foreach (var order in finalOrders)
            {
                if (order.FlightInfo != null)
                {
                    Console.WriteLine("order: {0}, flightNumber: {1} , departure: {2}, arrival: {3}, day: {4}",order.OrderNumber, order.FlightInfo.FlightId, order.FlightInfo.DepatureAirport, order.FlightInfo.ArrivalAirport, order.FlightInfo.Day);
                }
                else
                {
                    Console.WriteLine("order: {0}, flightNumber: not scheduled", order.OrderNumber);
                }
            }
        }
    }
}
