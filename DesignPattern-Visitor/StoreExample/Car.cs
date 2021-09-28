
using VisitorDesignPattern.StoreExample.Visitors;

namespace VisitorDesignPattern.StoreExample
{
    public class Car : IStore
    {
        public string CarName { get; set; }
        public decimal Price { get; set; }
        public string CarType { get; set; }

        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }
}
