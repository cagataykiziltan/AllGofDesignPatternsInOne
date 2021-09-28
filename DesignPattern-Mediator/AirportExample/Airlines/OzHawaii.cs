using System;

namespace DesignPattern_Mediator.Airlines
{
    public class OzHawaii : Airline
    {
        public override void GetWay(string messageFromAirport)
        {
            Console.WriteLine("Oz Hawaii, Flight {0} : ", FlightNumber);
            base.GetWay(messageFromAirport);
        }
    }
}
