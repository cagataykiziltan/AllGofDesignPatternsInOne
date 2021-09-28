namespace ChainOfResponsibilityPattern.BankExample
{
    public abstract class Employee
    {
        protected Employee NextApprover;

        public void SetNextApprover(Employee employee)
        {
            NextApprover = employee; 
        }
        public abstract void ProcessRequest(Withdraw req);
    }
}
