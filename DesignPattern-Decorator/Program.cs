using System;

namespace DesignPattern_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent component = new Component();

            Console.WriteLine("Basic Component " + component.Operation());
            Console.WriteLine("Decorator A " + new DecoratorA(component).Operation());
            Console.WriteLine("Decorator B " + new DecoratorB(component).Operation());
            Console.WriteLine("Decorator B - A" + new DecoratorB(new DecoratorA(component)).Operation());

            DecoratorB b = new DecoratorB(new Component());

            Console.WriteLine("b.addedState " + b.AddedBehavior());

            Console.ReadKey();

        }
    }

    interface IComponent
    {
        string Operation();
    }

    class Component : IComponent
    {
        public string Operation()
        {
            return "I am walking ";
        }
    }

    class DecoratorA : IComponent
    {
        readonly IComponent _component;

        public DecoratorA(IComponent component)
        {
            _component = component;
        }

        public string Operation()
        {
            string s = _component.Operation();
            s += " and listening to Classin FM";

            return s;
        }
    }

    class DecoratorB : IComponent
    {
        private readonly IComponent _component;
     
        public DecoratorB(IComponent component)
        {
            _component = component;
        }

        public string Operation()
        {
           
            string s = _component.Operation();
            s += " to School";

            return s;
        }

        public string AddedBehavior()
        {
            return " and I bought a cappicuno"; 
        }
    }
}
