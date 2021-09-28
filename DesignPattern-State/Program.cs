using StatePattern.VendingMachineExample;
using System;

namespace DesignPattern_State
{
    
    // Client
    class Program
    {
        static void Main(string[] args)
        {
            /***********************State Example***********************/
            VendingMachine machine = new VendingMachine();


            machine.RequestProduct("Chocolate K", 10);

            machine.RequestProduct("Bsissi", 12);



            /***********************Account Example***********************/
            //Account account = new Account();
            //account.WithdrawMoney();
            //account.PayInterest();

            //account.ChangeStatus(new GoldAccount());

            //account.WithdrawMoney();
            //account.PayInterest();

            Console.ReadKey();
        }
    }
}