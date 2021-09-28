
using System;

namespace BuilderPattern
{
    //Product class
    public class Pizza
    {
        public string PizzaTipi { get; set; }
        public string Hamur { get; set; }
        public string Sos { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", PizzaTipi, Hamur, Sos);
        }
    }
}
