using System;


namespace TemplatePattern.MallExample
{
    enum OdemeTipi
    {
        AdvancePrice,
        Installment
    }

    abstract class Mall
    {
        protected string produtName;
        protected OdemeTipi paymentType;
        void StartShopping() 
        {
            Console.WriteLine("Shopping started."); 
        }
        void FinishShopping() 
        {
            Console.WriteLine($"Shopping ended.{produtName} {paymentType} payment taken.");
        }
        abstract public void Product();
        abstract public void PaymentType();
        public void TemplateMethod()
        {
            StartShopping();
            Product();
            PaymentType();
            FinishShopping();
        }
    }
}
