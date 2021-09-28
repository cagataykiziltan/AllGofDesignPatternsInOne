using System;
using System.Collections.Generic;

namespace DesignPattern_Composite
{
    /// 
    /// Component sınıfı
    /// 
    abstract class Soldier
    {

        protected string _name;
        protected Rank _rank;

        public Soldier(string name, Rank rank)
        {
            _name = name;
            _rank = rank;
        }

        public abstract void AddSoldier(Soldier soldier);
        public abstract void RemoveSoldier(Soldier soldier);
        public abstract void ExecuteOrder(); // Hem Leaf hemde Composite tipi için uygulanacak olan fonksiyon

    }


    /// 
    /// Leaf class
    /// 
    class PrimitiveSoldier : Soldier
    {

        public PrimitiveSoldier(string name, Rank rank) : base(name, rank)
        {

        }
  
        public override void AddSoldier(Soldier soldier)
        {
            throw new NotImplementedException();
        }
  
        public override void RemoveSoldier(Soldier soldier)
        {
            throw new NotImplementedException();
        }

        public override void ExecuteOrder()
        {
            Console.WriteLine(String.Format("{0} {1}", _rank, _name));
        }

    }


    /// 
    /// Composite Class
    /// 
    class CompositeSoldier : Soldier
    {
     
        private List<Soldier> _soldiers = new List<Soldier>();

        public CompositeSoldier(string name, Rank rank) : base(name, rank)
        {

        }

      
        public override void AddSoldier(Soldier soldier)
        {
            _soldiers.Add(soldier);
        }

        public override void RemoveSoldier(Soldier soldier)
        {
            _soldiers.Remove(soldier);
        }

        public override void ExecuteOrder()
        {
            Console.WriteLine(string.Format("{0} {1}", _rank, _name));

            foreach (Soldier soldier in _soldiers)
            {
                soldier.ExecuteOrder();
            }

        }
    }
}
