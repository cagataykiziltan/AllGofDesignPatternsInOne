using System;

namespace DesignPattern_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var creator = new ScreenCreator();

            Screen screenWindows = creator.ScreenFactory(ScreenModel.Windows);
            Screen screenWeb = creator.ScreenFactory(ScreenModel.Web);
            Screen screenMobile = creator.ScreenFactory(ScreenModel.Mobile);

            screenWindows.Draw();
            screenWeb.Draw();
            screenMobile.Draw();

            Console.ReadKey();
        }

    }

}
