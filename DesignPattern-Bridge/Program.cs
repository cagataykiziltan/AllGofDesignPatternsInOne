using System;
namespace DesignPattern_Bridge
{
    interface IBridge
    {
        string OperationImp();
    }

    class ImplementationA : IBridge
    {
        public string OperationImp()
        {
            return "Implementation A";
        }
    }   

    class ImplementationB : IBridge
    {
        public string OperationImp()
        {
            return "Implementation B";
        }
    }
    class Abstraction
    {
        readonly IBridge bridge;

        public Abstraction(IBridge Implementation)
        {
            bridge = Implementation;
        }

        public string Operation()
        {
            return "Abstraction <<bridge>>  " + bridge.OperationImp();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bridge Pattern \n");
            Console.WriteLine(new Abstraction(new ImplementationA()).Operation());
            Console.WriteLine(new Abstraction(new ImplementationB()).Operation());

            Console.ReadKey();
        }
    }

}
