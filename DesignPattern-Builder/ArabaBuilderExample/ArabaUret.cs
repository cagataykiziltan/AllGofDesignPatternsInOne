
namespace BuilderPattern.ArabaBuilderExample
{
    //Director Class
    public class ArabaUret
    {
        public void Uret(IArabaBuilder builder)
        {
            builder.SetMarka();
            builder.SetModel();
            builder.SetVites();
            builder.SetKM();
        }
    }
}
