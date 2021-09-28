using System;


namespace FlyweightPattern.Flyweight
{
   public class Sergeant : Soldier
    {

        public Sergeant()
        {
            UnitName = "SWAT";
            Guns = "Sword";
            Health = "Good";
        }

        public override void MoveTo(int x, int y)
        {
            X = x;
            Y = y;

            Console.WriteLine("Sergeant moved to point ({0}:{1})", X, Y);
        }

    }
}
