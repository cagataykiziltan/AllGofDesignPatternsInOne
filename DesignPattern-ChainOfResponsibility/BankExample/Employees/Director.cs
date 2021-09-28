using System;


namespace ChainOfResponsibilityPattern.BankExample
{
    public class Director : Employee
    {
        public override void ProcessRequest(Withdraw req)
        {
            if (req.Amount <= 750000)
            {
                Console.WriteLine("Loan request process approved by {0} {1} TL", this.GetType().Name, req.Amount);
            }
            else
            {
                throw new Exception( $"#{req.Amount} TL Loan request limit couldnt be approved because of limit.");
            }
        }
    }
}
