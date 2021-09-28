using DesignPattern_Mediator.Mediator;
using System;

namespace DesignPattern_Mediator.Airlines
{
    public abstract class Airline
    {
        public IAirportControl Airport { get; set; }
        public string FlightNumber { get; set; }
        public string From { get; set; }

        public void RequestNewWay(string myWay)
        {
            Airport.SuggestWay(FlightNumber, myWay);
        }

        public virtual void GetWay(string messageFromAirport)
        {
            Console.WriteLine("We need to take the {0} route.", messageFromAirport);
        }
    }
}