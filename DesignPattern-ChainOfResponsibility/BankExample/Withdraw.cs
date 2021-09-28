using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern.BankExample
{

    public class Withdraw
    {
        public string CustomerId { get; }
        public decimal Amount { get; }
        public string CurrencyType { get; }
        public string SoruceAccountId { get; }

        public Withdraw(string customerId, decimal amount, string currencyType, string soruceAccountId)
        {
            CustomerId = customerId;
            Amount = amount;
            CurrencyType = currencyType;
            SoruceAccountId = soruceAccountId;
        }
    }
}
