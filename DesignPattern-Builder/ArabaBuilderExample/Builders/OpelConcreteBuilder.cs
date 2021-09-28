namespace BuilderPattern.ArabaBuilderExample.Builders
{
    public class OpelConcreteBuilder : IArabaBuilder
    {
        public OpelConcreteBuilder()
        {
            araba = new Araba();
        }

        public override void SetKM() => araba.KM = 150;

        public override void SetMarka() => araba.Marka = "OPEL";

        public override void SetModel() => araba.Model = "Astra";

        public override void SetVites() => araba.Vites = false;
    }
}
