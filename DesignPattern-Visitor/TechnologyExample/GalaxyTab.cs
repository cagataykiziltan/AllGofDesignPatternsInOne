

namespace VisitorDesignPattern.TechnologyExample
{
    public class GalaxyTab : Tablet
    {
        public GalaxyTab(string model, string brand)  : base(model, brand)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
