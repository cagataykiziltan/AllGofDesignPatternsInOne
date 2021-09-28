using System;

namespace ChainOfResponsibilityPattern.BankExample
{
    public class Responsible : Employee
    {
        public override void ProcessRequest(Withdraw req)
        {
            if (req.Amount <= 40000)
            {
                Console.WriteLine("{0} tarafından para çekme işlemi onaylandı #{1}", this.GetType().Name, req.Amount);
            }
            else if (NextApprover != null)
            {
                Console.WriteLine("{0} TL işlem tutarı {1} max. limitini aştığından işlem yöneticiye gönderildi.", req.Amount, this.GetType().Name);

                NextApprover.ProcessRequest(req);
            }
        }
    }
}
