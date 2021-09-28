
namespace CommandPattern.Command
{
    public class SimpleRemoteControl
    {
        ICommand slot;  // only one button 

        public SimpleRemoteControl()
        {
        }

        public void SetCommand(ICommand command)
        {
            // set the command the remote will 
            // execute 
            slot = command;
        }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}
