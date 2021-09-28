
namespace BuilderPattern
{
    //Builder class
    public abstract class PizzaBuilder
    {
        protected Pizza _pizza;

        public Pizza Pizza { get { return _pizza; } }

        public abstract void SosuHazirla();
        public abstract void HamuruHazirla();
    }
}
