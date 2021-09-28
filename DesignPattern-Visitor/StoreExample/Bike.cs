
using VisitorDesignPattern.StoreExample.Visitors;

namespace VisitorDesignPattern.StoreExample
{
    public class Bike : IStore
    {
        public string BikeName { get; set; }
        public decimal Price { get; set; }
        public string BikeType { get; set; }

        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }
}
