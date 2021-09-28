

using TemplatePattern.MallExample;

namespace TemplatePattern.AlisverisExample
{
    class Television : Mall
    {
        public override void PaymentType()
        {
            paymentType = OdemeTipi.AdvancePrice;
        }

        public override void Product()
        {
            produtName = "Tv";
        }
    }

    class Refrigerator : Mall
    {
        public override void PaymentType()
        {
            paymentType = OdemeTipi.Installment;
        }

        public override void Product()
        {
            produtName = "Refrigerator";
        }
    }

}
