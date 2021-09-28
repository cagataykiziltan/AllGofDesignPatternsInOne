
namespace BuilderPattern
{
    //Concrete Builder 2
    public class DortMevsimPizzaBuilder : PizzaBuilder
    {
        public DortMevsimPizzaBuilder()
        {
            _pizza = new Pizza { PizzaTipi = "4 Mevsim" };
        }
        public override void SosuHazirla()
        {
            _pizza.Sos = "Biber, Domates, Peynir, Salam, Sosis";
        }

        public override void HamuruHazirla()
        {
            _pizza.Hamur = "Kalın, fesleğenli";
        }
    }
}
