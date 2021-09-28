using ChainOfResponsibilityPattern.BankExample;
using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var withdraw = new Withdraw("a6e193dc-cdbb-4f09-af1a-dea307a9ed15", 480000, "TRY", "TR681223154132432141412");

            Employee responsible = new Responsible();
            Employee manager = new Manager();
            Employee groupManage = new GroupManager();
            Employee director = new Director();

            responsible.SetNextApprover(manager);
            manager.SetNextApprover(groupManage);
            groupManage.SetNextApprover(director);

            responsible.ProcessRequest(withdraw);

            Console.ReadKey();
        }
    }
}

