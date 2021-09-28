using System;

namespace DesignPattern_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory(new InterbaseFactory());
            factory.Start();

            Console.WriteLine("");

            Factory factory2 = new Factory(new Db2Factory());
            factory2.Start();

            Console.ReadKey();
        }
    }
}
