using System;


namespace MediatorPattern.ChatExample
{
    class ConcreteColleague1 : Participant
    {
        public ConcreteColleague1(string name) : base(name)
        {

        }

        public override void MessageReceiver(string fromWho, string message)
        {
            Console.Write("Whom -> ConcreteColleague1: ");
            base.MessageReceiver(fromWho, message);
        }
    }

    class ConcreteColleague2 : Participant
    {
        public ConcreteColleague2(string name) : base(name)
        {

        }

        public override void MessageReceiver(string fromWho, string message)
        {
            Console.Write("Whom -> ConcreteColleague2: "); 
            base.MessageReceiver(fromWho, message);

        }

    }
}
