using System;


namespace MediatorPattern.ChatExample
{
    public class Participant
    {
        public string Name { get; }
        public ConcreteMediator ConcreteMediator { set; get; }

        public Participant(string name)
        {
            Name = name;
        }
        
        public void SendMessage(string whom, string message)
        {
            ConcreteMediator.SendMessage(Name, whom, message);
        }


        public virtual void MessageReceiver(string fromWho, string message)
        {
             Console.WriteLine("{0} to {1}: '{2}'", fromWho, Name, message);

        }

    }
}
