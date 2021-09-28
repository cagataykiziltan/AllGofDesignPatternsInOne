

namespace BuilderPattern
{
    //Director class
    public class VenedikliKamil
    {
        public void Olustur(PizzaBuilder vBuilder)
        {
            vBuilder.SosuHazirla();
            vBuilder.HamuruHazirla();
        }
    }
}
