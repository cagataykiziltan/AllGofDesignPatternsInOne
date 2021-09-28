
namespace MediatorPattern.ChatExample
{
   public  interface IMediator
    {
        public abstract void Register(Participant katilimci);

        public abstract void SendMessage(string kimden, string kime, string mesaj);
    }
}
