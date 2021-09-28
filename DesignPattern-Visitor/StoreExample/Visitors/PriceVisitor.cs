using System;

namespace VisitorDesignPattern.StoreExample.Visitors
{
    public class PriceVisitor : IVisitor
    {
        private const int CAR_DISCOUNT = 5;
        private const int BIKE_DISCOUNT = 2;

        public void Accept(Car car)
        {
            decimal carPriceAfterDicount = car.Price - ((car.Price / 100) * CAR_DISCOUNT);
            Console.WriteLine("Car {0} price: {1}", car.CarName, carPriceAfterDicount);
        }

        public void Accept(Bike bike)
        {
            decimal bikePriceAfterDicount = bike.Price - ((bike.Price / 100) * BIKE_DISCOUNT);
            Console.WriteLine("Bike {0} price: {1}", bike.BikeName, bikePriceAfterDicount);
        }
    }
}
