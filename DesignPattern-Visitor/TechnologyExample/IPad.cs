

namespace VisitorDesignPattern.TechnologyExample
{
    public class IPad : Tablet
    {
        public IPad(string model, string brand)  : base(model, brand)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
