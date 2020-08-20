
using System;

namespace CodingTestAirTech
{
    class Program
    {
        static void Main(string[] args)
        {
            UserStory1 userStory1 = new UserStory1();
            UserStory2 userStory2 = new UserStory2(20);
            userStory1.printFlightDetails();
            userStory2.PrintOrders();
            Console.ReadLine();
        }
    }
}
