
using System;

namespace CommandPattern.Command
{
    public class Stereo
    {
        public void On()
        {
            Console.WriteLine("Stereo is on");
        }
        public void Off()
        {
            Console.WriteLine("Stereo is off");
        }
        public void SetCD()
        {
            Console.WriteLine("Stereo is set for CD input");
        }
        public void SetDVD()
        {
            Console.WriteLine("Stereo is set for DVD input");
        }
        public void SetRadio()
        {
            Console.WriteLine("Stereo is set for Radio");
        }
        public void SetVolume(int volume)
        {
            // code to set the volume 
            Console.WriteLine("Stereo volume set to " + volume);
        }
    }
}
