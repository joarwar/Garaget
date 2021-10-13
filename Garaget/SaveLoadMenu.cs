using System;

namespace Garaget
{
    class SaveLoadMenu : Menu
    {
        public override bool HandleInput()
        {
            int saveLoadMenu = ParseInput(Console.ReadLine(), 3);
            switch (saveLoadMenu)
            {
                case 1:
                    Program.garage.SaveState(Program.path);
                    break;
                case 2:
                    Program.garage.RestoreState(Program.path);
                    break;
                case 3:
                    return true;
                default:
                    Console.WriteLine("Try again!");
                    break;
            }
            Console.WriteLine("Press any key to continue....");
            Console.ReadLine();
            return false;
        }

        public override Menu ShowMenu()
        {
            Console.WriteLine("What do you want to do?" +
                "\n1. Saved current garage" +
                "\n2. Open saved garages" +
                "\n3. Go back to main menu");
            HandleInput();
            return new MainMenu();
        }
    }
}
