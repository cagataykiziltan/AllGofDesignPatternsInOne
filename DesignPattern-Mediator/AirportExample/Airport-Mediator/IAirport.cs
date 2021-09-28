using DesignPattern_Mediator.Airlines;

namespace DesignPattern_Mediator.Mediator
{
    public interface IAirportControl
    {
        void Register(Airline airLine);
        void SuggestWay(string fligthNumber, string way);
    }
}
