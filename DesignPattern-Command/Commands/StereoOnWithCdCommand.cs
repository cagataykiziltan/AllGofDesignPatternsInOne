
namespace CommandPattern.Command
{
    public class StereoOnWithCdCommand : ICommand
    {
        Stereo stereo;
        public StereoOnWithCdCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            stereo.On();
            stereo.SetCD();
            stereo.SetVolume(11);
        }
    }
}
