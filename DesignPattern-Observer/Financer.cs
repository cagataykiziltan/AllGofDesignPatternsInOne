using System;


namespace DesignPattern_Observer
{
    interface IFinancer
    {
        void Update(Stock stock);
    }

    class Financier : IFinancer
    {
        public string Name { get; set; }

        public void Update(Stock stock)
        {
            Console.WriteLine("{0} hissesinin lot değeri {1} olarak güncellendi", stock.Name, stock.LotValue.ToString("C2"));
        }
    }
}
