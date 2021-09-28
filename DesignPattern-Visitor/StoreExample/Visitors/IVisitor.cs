
namespace VisitorDesignPattern.StoreExample.Visitors
{
    public interface IVisitor
    {
        void Accept(Car car);
        void Accept(Bike bike);
    }
}
