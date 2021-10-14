using System;

namespace Garaget
{
    class ExitMenu : Menu
    {
        public override void ShowMenu()
        {
            Console.WriteLine("Thank you for using our garage");
        }

        public override int HandleInput()
        {
            return 0;
        }

        public override Menu GetNextMenu(int input)
        {
            return null;
        }
    }
}
