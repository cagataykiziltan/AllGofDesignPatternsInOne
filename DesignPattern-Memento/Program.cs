using System;

namespace DesignPattern_Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            GameWorld zulu = new GameWorld { Name = "Zulu", Population = 100000 };

            Console.WriteLine(zulu.ToString());

            GameWorldCareTaker taker = new GameWorldCareTaker();
            taker.World = zulu.Save(); //save current status of zulu

            zulu.Population += 10;
            Console.WriteLine(zulu.ToString());

            zulu.Undo(taker.World); //reloads old world

            Console.WriteLine(zulu.ToString());

            Console.ReadKey();
        }
    }
}
