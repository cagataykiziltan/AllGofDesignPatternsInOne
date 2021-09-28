using System;

namespace DesignPattern_Factory
{
    //Abstract parent class
    public abstract class Screen
    {
        public abstract void Draw();
    }

    //Concrete Product
    class WinScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Windows screen");
        }
    }

    //Concrete Product
    class WebScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Web screen");
        }

    }

    //Concrete Product
    class MobileScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Mobile screen");
        }
    }

}
