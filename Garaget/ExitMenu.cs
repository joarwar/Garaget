using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget
{
    class ExitMenu : Menu
    {
        public int AmountOfMenuItems { get; set; }
        public Menu NextMenu { get; set; }

        public ExitMenu()
        {
            AmountOfMenuItems = 1;
        }

        public override Menu ShowMenu()
        {
            Console.WriteLine("Select option:"+
                "\n1. Quit"+
                "\n0. Return to main menu");
            HandleInput();
            return new MainMenu();
        }

        public override bool HandleInput()
        {
            int selection;
            do
            {
                Console.WriteLine("Enter your choice");
                selection = ParseInput(Console.ReadLine(), AmountOfMenuItems);
            } while(selection >= 0 && selection <= AmountOfMenuItems);
            switch(selection)
            {
                case 1:
                    NextMenu = new MainMenu();
                    break;
                case 2:
                    ApplicationQuit();
                    break;
                default:
                    break;
            }
            return true;
        }

        private void ApplicationQuit()
        {
            Environment.Exit(0);
        }
    }
}
