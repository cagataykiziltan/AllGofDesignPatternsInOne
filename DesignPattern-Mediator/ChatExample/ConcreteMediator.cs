using System.Collections.Generic;

namespace MediatorPattern.ChatExample
{
    public class ConcreteMediator : IMediator

    {

        private Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();


        public  void Register(Participant participant)
        {
            if (!_participants.ContainsValue(participant))
            {
                _participants[participant.Name] = participant;
            }

            participant.ConcreteMediator = this;
        }

        public  void SendMessage(string fromwho, string whom, string message)
        {

            Participant participant = _participants[whom];
            
            if (participant != null)
            {
                participant.MessageReceiver(fromwho, message);
            }

        }

    }
}