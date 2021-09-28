
using System;

namespace StatePattern.HesapExample
{
    public class GoldAccount : IAccountState
    {
        public void PayInterest()
        {
            Console.WriteLine("Interest paid with Golden Account");
        }

        public void WithdrawMoney()
        {

            Console.WriteLine("Money is taken with Golden Account");
        }

    }
}
