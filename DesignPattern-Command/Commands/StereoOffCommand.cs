namespace CommandPattern.Command
{
    public class StereoOffCommand : ICommand
    {
        Stereo stereo;
        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            stereo.Off();
        }
    }
}
