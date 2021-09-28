
namespace CommandPattern.Command
{
    public class LightOnCommand : ICommand
    {
        Light light;

        // The constructor is passed the light it 
        // is going to control. 
        public LightOnCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.On();
        }
    }
}
