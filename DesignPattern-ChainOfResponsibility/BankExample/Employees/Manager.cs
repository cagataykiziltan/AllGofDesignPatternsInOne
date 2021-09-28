using System;


namespace ChainOfResponsibilityPattern.BankExample
{
    public class Manager : Employee
    {
        public override void ProcessRequest(Withdraw req)
        {
            if (req.Amount <= 70000)
            {
                Console.WriteLine("Loan request process approved by {0} {1} TL", this.GetType().Name, req.Amount);
            }
            else if (NextApprover != null)
            {
                Console.WriteLine("{0} Loan request sent to  {1} because of request limit.", req.Amount, this.GetType().Name);

                NextApprover.ProcessRequest(req);
            }
        }
    }
}
