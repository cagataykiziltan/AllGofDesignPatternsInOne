
namespace BuilderPattern.ArabaBuilderExample.Builders
{
    public class BMWConcreteBuilder : IArabaBuilder
    {
        public BMWConcreteBuilder()
        {
            araba = new Araba();
        }

        public override void SetKM() => araba.KM = 100;

        public override void SetMarka() => araba.Marka = "BMW";

        public override void SetModel() => araba.Model = "320";

        public override void SetVites() => araba.Vites = true;
    }
}
