namespace BuilderPattern
{
    //Concrete Builder 1
    public class BaharatliPizzaBuilder : PizzaBuilder
    {
        public BaharatliPizzaBuilder()
        {
            _pizza = new Pizza { PizzaTipi = "Baharatlı Pizza" };
        }
        public override void HamuruHazirla()
        {
            _pizza.PizzaTipi = "Baharatli Pizza";
        }

        public override void SosuHazirla()
        {
            _pizza.Sos = "İnce Kenar, Kaşarlı";
        }
    }
}
