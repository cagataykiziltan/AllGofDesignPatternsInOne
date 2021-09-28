using System;
using TemplatePattern.AlisverisExample;
using TemplatePattern.MallExample;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Mall a1 = new Television();
            a1.TemplateMethod();
            
            Console.WriteLine("***********");
           
            Mall a2 = new Refrigerator();
            a2.TemplateMethod();

            Console.Read();
        }
    }
}
