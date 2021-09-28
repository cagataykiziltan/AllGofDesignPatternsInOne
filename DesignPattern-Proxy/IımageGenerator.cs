using System;

namespace DesignPattern_Proxy
{
    //Subject
    interface IImageGenerator
    {
         void ShowImage();
    }

    //Real Subject
    public class ImageGenerator : IImageGenerator
    {
         private readonly string _fullPath;

         public ImageGenerator(string fullPath)
         {
             _fullPath = fullPath;
         }
         public void ShowImage()
         {
             Console.WriteLine("{0} shown image", _fullPath);
         }
    }

     //Proxy Subject
     public class ImageGeneratorProxy : IImageGenerator
     {
          public ImageGenerator _generator;
          private readonly string _fullPath;

          public ImageGeneratorProxy(string fullPath)
          {
             _fullPath = fullPath;
          }         

          public void ShowImage()
          {
              if (_generator == null)
              {  
                  _generator = new ImageGenerator(_fullPath);
              }

              _generator.ShowImage();
          }
     }
}
