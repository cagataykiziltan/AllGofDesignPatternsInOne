using System;
using System.Linq;
using System.Threading;

namespace StatePattern.VendingMachineExample
{
    //Concrete state type
    class InitializeState : VendingMachineState
    {
        public InitializeState()
        {
            Console.WriteLine("Initialize...");
        }
        public override void HandleState(VendingMachine context)
        {
            Console.WriteLine("Preparing...");
            Thread.Sleep(2000);

            context.State = new WaitingState();
        }
    }

    //Concrete state type
    class PreparingState : VendingMachineState
    {
        public PreparingState()
        {
            Console.WriteLine("Preparing...");
        }
        public override void HandleState(VendingMachine context)
        {
            Console.WriteLine("The desired product is being prepared. Please wait");

            context.State = new DeliveryState();
        }
    }

    //Concrete state type
    class WaitingState : VendingMachineState
    {
        public WaitingState()
        {
            Console.WriteLine("Waiting...");
        }
        public override void HandleState(VendingMachine context)
        {
            int totalProduct = context.ProductList.Sum<Product>(p => p.Count);

            Console.WriteLine("The machine is in standby. There are {0} products currently.", totalProduct.ToString());
        }
    }

    //Concrete state type
    class DeliveryState : VendingMachineState
    {
        public DeliveryState()
        {
            Console.WriteLine("Delivering...");
        }
        public override void HandleState(VendingMachine context)
        {
            Console.WriteLine("The product is being delivered");
            context.State = new WaitingState();
        }
    }
}
