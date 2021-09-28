

namespace BuilderPattern.ArabaBuilderExample.Builders
{
    public class ToyotaConcreteBuilder : IArabaBuilder
    {
        public ToyotaConcreteBuilder()
        {
            araba = new Araba();
        }

        public override void SetKM() => araba.KM = 25;

        public override void SetMarka() => araba.Marka = "Toyota";

        public override void SetModel() => araba.Model = "Corolla";

        public override void SetVites() => araba.Vites = false;
    }
}
