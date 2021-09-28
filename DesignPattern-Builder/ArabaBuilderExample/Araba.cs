namespace BuilderPattern.ArabaBuilderExample
{
    //Product Class
    public class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double KM { get; set; }
        public bool Vites { get; set; }
        public override string ToString()
        {
            return $"{Marka} marka araba {Model} modelinde {KM} kilometrede {Vites} vites olarak üretilmiştir.";
        }
    }
}
