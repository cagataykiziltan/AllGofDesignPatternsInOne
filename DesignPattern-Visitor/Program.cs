using System;
using System.Collections.Generic;
using VisitorDesignPattern.StoreExample;
using VisitorDesignPattern.StoreExample.Visitors;
using VisitorDesignPattern.TechnologyExample;

namespace VisitorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //****************** TECHNOLOGY EXAMPLE *************************
            //IPad iPad = new IPad("Ipad mini", "Apple");
            //GalaxyTab galaxyTab = new GalaxyTab("Galaxy Tab", "Samsung");

            //iPad.Accept(new WifiVisitor());
            //galaxyTab.Accept(new WifiVisitor());

            //iPad.Accept(new ThreeGVisitor());
            //galaxyTab.Accept(new ThreeGVisitor());

            //*************************************************************

            //****************** STORE EXAMPLE *************************

            List<IStore> store = new List<IStore>();
            IStore car1=  new Car() { CarName = "A1", Price = 200M, CarType = "Mercedes" };
            IStore car2 = new Car() { CarName = "A2", Price = 100M, CarType = "Normal" };

            IStore bike1 = new Bike() { BikeName = "B1", Price = 50M, BikeType = "Bullet" };
            IStore bike2 = new Bike() { BikeName = "B2", Price = 30M, BikeType = "Normal" };

            //Show price of each item
            PriceVisitor priceVisitor = new PriceVisitor();
            car1.Visit(priceVisitor);
            car2.Visit(priceVisitor);

            bike1.Visit(priceVisitor);
            bike2.Visit(priceVisitor);

            //Show weight of each item
            WeightVisitor weightVisitor = new WeightVisitor();
            car1.Visit(weightVisitor);
            car2.Visit(weightVisitor);

            bike1.Visit(weightVisitor);
            bike2.Visit(weightVisitor);





            //*************************************************************
            Console.ReadLine();
        }
    }
}
