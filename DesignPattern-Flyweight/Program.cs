using FlyweightPattern.Flyweight;
using System;

namespace FlyweightPattern
{
    class Program
    {
        public static void Main()
        {
                   
            SoldierType[] soldiers = { SoldierType.Private, SoldierType.Private, SoldierType.Sergeant, SoldierType.Private, SoldierType.Sergeant };
                    
            SoldierFactory factory = new SoldierFactory();
          
            int localtionX = 10;
            int locationY = 10;

            foreach (SoldierType soldier in soldiers)
            {
                localtionX += 10;
                locationY += 5;

            
                Soldier _soldier = factory.GetSoldier(soldier);


                _soldier.MoveTo(localtionX, locationY);

            }

        }
    }
}
