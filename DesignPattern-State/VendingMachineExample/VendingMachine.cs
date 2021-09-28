using System;
using System.Linq;
using System.Collections.Generic;

namespace StatePattern.VendingMachineExample
{
    // Context tipi
    class VendingMachine
    {
        public List<Product> ProductList = new List<Product>();
        private VendingMachineState _state;

        public VendingMachineState State
        {
            get { return _state; }
            set
            {
                _state = value;
                _state.HandleState(this);
            }
        }

        public VendingMachine()
        {
            ProductList.Add(new Product { Name = "Chocolate K", ListPrice = 10, Count = 50 });
            ProductList.Add(new Product { Name = "Biscuit Bis", ListPrice = 3.45, Count = 50 });
            ProductList.Add(new Product { Name = "Cracker", ListPrice = 4.50, Count = 35 });

            State = new InitializeState();
        }
        public void RequestProduct(string productName, double money)
        {
            Console.WriteLine("The product order has arrived. Coin for {0} : {1}", productName, money);
            Product prd = (from p in ProductList
                           where p.Name == productName && money >= p.ListPrice && p.Count >= 1
                           select p).SingleOrDefault();

            if (prd != null)
            {
                prd.Count--;
                State = new PreparingState();
            }
            else
                State = new WaitingState();
        }
    }

}
