using System.Collections.Generic;

namespace FlyweightPattern.Flyweight
{
  public class SoldierFactory
    {
     
        private readonly Dictionary<SoldierType, Soldier> _soldiers;

        public SoldierFactory()
        {
            _soldiers = new Dictionary<SoldierType, Soldier>();
        }

        public Soldier GetSoldier(SoldierType soldierType)
        {
            Soldier soldier = null;
            
            if (_soldiers.ContainsKey(soldierType))
                soldier = _soldiers[soldierType];
            else
            {        
                if (soldierType == SoldierType.Private)
                    soldier = new Private();
                if (soldierType == SoldierType.Sergeant)
                    soldier = new Sergeant();

                _soldiers.Add(soldierType, soldier);
            }

            
            return soldier;

        }

    }
}
