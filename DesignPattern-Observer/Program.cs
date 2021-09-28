using System;

namespace DesignPattern_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock azonDemir = new Stock { Name = "Azone Iron Chemistry", LotValue = 12.3M };

            Financier xYatirim = new Financier { Name = "X investment company" };

            azonDemir.Subscribe(xYatirim); //xYatirimi güncelleme alabilmesi için abone ettik.

            Financier zBank = new Financier { Name = "z bank company" };

            azonDemir.Subscribe(xYatirim); //zBank güncelleme alabilmesi için abone ettik.

            Console.WriteLine("{0} current lot value of the stock {1}", azonDemir.Name, azonDemir.LotValue.ToString("C2"));

            azonDemir.LotValue += 1;

            Console.ReadKey();
        }
    }
}
