using System;

namespace Garaget
{
    class ExitMenu : Menu
    {
        public override Menu ShowMenu()
        {
            Console.WriteLine("Thank you for using our garage. The garage has been saved.");
            return null;
        }

        public override bool HandleInput()
        {
            return false;
        }

    }
}
