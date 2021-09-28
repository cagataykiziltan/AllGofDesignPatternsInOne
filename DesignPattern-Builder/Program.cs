using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VenedikliKamil kamilUsta = new VenedikliKamil();

            PizzaBuilder dortmevsimPizzaBuilder = new DortMevsimPizzaBuilder();
            kamilUsta.Olustur(dortmevsimPizzaBuilder);
        
            Console.WriteLine(dortmevsimPizzaBuilder.Pizza.ToString());

            PizzaBuilder baharatliPizzaBuilder = new BaharatliPizzaBuilder();
            kamilUsta.Olustur(baharatliPizzaBuilder);


            Console.WriteLine(baharatliPizzaBuilder.Pizza.ToString());

            Console.ReadKey();
        }
    }
}
