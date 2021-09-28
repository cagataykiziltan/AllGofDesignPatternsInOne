namespace FlyweightPattern.Flyweight
{
   public abstract class Soldier
    {

        #region Intrinsic Fields
       
        protected string UnitName;
        protected string Guns;
        protected string Health;

        #endregion


        #region Extrinsic Fields
    
        protected int X;
        protected int Y;

        #endregion

        public abstract void MoveTo(int x, int y);
    }
}
