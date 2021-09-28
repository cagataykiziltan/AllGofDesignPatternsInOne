using CommandPattern.Command;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl remote =  new SimpleRemoteControl();
            Light light = new Light();
            Stereo stereo = new Stereo();

        
            remote.SetCommand(new LightOnCommand(light));
            remote.ButtonWasPressed();
            
            remote.SetCommand(new StereoOnWithCdCommand(stereo));
            remote.ButtonWasPressed();
          
            remote.SetCommand(new StereoOffCommand(stereo));
            remote.ButtonWasPressed();

            Console.ReadKey();
        }
    }
}
