using System;


namespace FlyweightPattern.Flyweight
{
    public class Private : Soldier
    {

        public Private()
        {
            UnitName = "SWAT";
            Guns = "Machine Gun";
            Health = "Good";
        }

        public override void MoveTo(int x, int y)
        {        
            X = x;
            Y = y;
            Console.WriteLine("Soldier moved to point ({0}:{1})", X, Y);

        }

    }
}
