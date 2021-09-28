using DesignPattern_Mediator.Airlines;
using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPattern_Mediator.Mediator
{
    public class IstanbulControl : IAirportControl
    {
        private Dictionary<string, Airline> _planes;

        public IstanbulControl()
        {
            _planes = new Dictionary<string, Airline>();
        }

        #region IAirportControl Members

        public void Register(Airline airLine)
        {
            if (!_planes.ContainsValue(airLine))
                _planes[airLine.FlightNumber] = airLine;

            airLine.Airport = this;
        }

        public void SuggestWay(string fligthNumber, string way)
        {
            Thread.Sleep(250);
            Random rnd = new Random();
            _planes[fligthNumber].GetWay(string.Format("{0}:{1}E;{2}:{3}W", 
                                         rnd.Next(1, 100).ToString(), 
                                         rnd.Next(1, 100).ToString(), 
                                         rnd.Next(1, 100).ToString(), 
                                         rnd.Next(1, 100).ToString()));
        }

        #endregion
    }
}
