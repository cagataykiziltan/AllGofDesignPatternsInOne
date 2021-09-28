using System;
using System.Collections;

namespace DesignPattern_Iterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var basket = new ShoppingBasket();

            foreach (Product urun in basket)
                Console.WriteLine("Product: {0}, Price {1}", urun.Name, urun.Price);

            Console.ReadLine();

        }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

  
  
}
