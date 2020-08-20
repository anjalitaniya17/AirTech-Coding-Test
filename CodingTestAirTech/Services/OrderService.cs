using CodingTestAirTech.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodingTestAirTech
{
    public static class OrderService
    {
        private static List<OrderInforrmation> GetOrders()
        {   
            string fileName = "Data/coding-assignment-orders.json";
            var items = new Dictionary<string, DestinationForAirport>();
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<Dictionary<string, DestinationForAirport>>(json);
            }
            return items.Select(x => new OrderInforrmation { OrderNumber = x.Key, ArrivalAirport = x.Value.destination }).ToList(); 
        }

        public static List<OrderInforrmation> GetOrderDetails(int capacityOfFlight)
        {
            var orderList = GetOrders();
            var flightList = FlightSceduleService.GetFlightsSchedules();

            foreach (var flight in flightList)
            {
                var orders = orderList.Where(x => x.ArrivalAirport == flight.ArrivalAirport).Where(y => y.FlightInfo == null).Take(capacityOfFlight);
                foreach (var order in orders)
                {
                    var foundOrder = orderList.Find(o => o == order);
                    foundOrder.FlightInfo = flight;
                }
            }
            return orderList;
        }
    }
}
