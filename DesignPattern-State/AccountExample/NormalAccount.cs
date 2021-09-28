
using System;

namespace StatePattern.HesapExample
{
    public class NormalAccount : IAccountState
    {
        public void PayInterest()
        {
            Console.WriteLine("Interest paid with Normal Account");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("Money is taken with Normal Account");
        }
    }
}
