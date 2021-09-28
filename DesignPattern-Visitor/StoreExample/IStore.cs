
namespace VisitorDesignPattern.StoreExample.Visitors
{
    public interface IStore
    {
        void Visit(IVisitor visitor);
    }

}
