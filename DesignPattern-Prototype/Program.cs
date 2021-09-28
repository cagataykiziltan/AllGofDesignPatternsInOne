using System;

namespace DesignPattern_Prototype
{
    abstract class AdventurePrototype
    {
        public abstract AdventurePrototype Clone();
    }

    //Concrete Prototype
    class Product : AdventurePrototype
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal ListPrice { get; set; }

        public Product(int productId, string name, decimal listPrice)
        {
            ProductId = productId;
            Name = name;
            ListPrice = listPrice;
        }

        public override AdventurePrototype Clone()
        {
            return MemberwiseClone() as AdventurePrototype;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product lcdTv = new Product(1000, "ABC Lcd TV 106", 1000);

            Product lcdTV2 = lcdTv.Clone() as Product;

            Console.ReadKey();
        }

    }

}
