using DesignPattern.AltSistem;
using System;

namespace DesignPattern
{
    class Facade
    {
        private Bank _bank;
        private CentralBank _centralBank;
        private Credit _kredi;

        public Facade()
        {
            _bank = new Bank();
            _centralBank = new CentralBank();
            _kredi = new Credit();

        }

        public void UseCredit(Client client, decimal request)
        {
            if (!_centralBank.CheckBlackList(client.Id) && _kredi.CreditAvailability(client))
            {
                _bank.UseCredit(client, request);
                Console.WriteLine("Credit has been given");
            }

        }
    }
}
