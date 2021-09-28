using System;

namespace DesignPattern_Mediator.Airlines
{
    public class ZorluYol : Airline
    {
        public override void GetWay(string messageFromAirport)
        {
            Console.WriteLine("ZorluYol, Flight {0} : ", FlightNumber);
            base.GetWay(messageFromAirport);
        }
    }

}
