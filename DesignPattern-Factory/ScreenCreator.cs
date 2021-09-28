namespace DesignPattern_Factory
{
    enum ScreenModel
    {
        Windows,
        Web,
        Mobile
    }
    class ScreenCreator
    {
        public Screen ScreenFactory(ScreenModel screenModel)
        {
            Screen screen = null;

            switch (screenModel)
            {
                case ScreenModel.Windows:
                    screen = new WinScreen();
                    break;

                case ScreenModel.Web:
                    screen = new WebScreen();
                    break;

                case ScreenModel.Mobile:
                    screen = new MobileScreen();
                    break;

            }

            return screen;
        }
    }
}
