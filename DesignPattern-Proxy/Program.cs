using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_Proxy
{   

    class Program
    {
        static void Main(string[] args)
        {
            ImageGeneratorProxy proxy1 = new ImageGeneratorProxy("c:\\resim1.jpg");
            ImageGeneratorProxy proxy2 = new ImageGeneratorProxy("c:\\resim2.jpg");

            proxy1.ShowImage();
            proxy2.ShowImage();
            proxy1.ShowImage();

            Console.ReadKey();
        }
    }
}
