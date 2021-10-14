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
                    Console.WriteLine("Garage saved");
                    break;
                case 2:
                    Program.garage.RestoreState(Program.path);
                    Console.WriteLine("Garage loaded with the following vehicles:\n");
                    foreach(Vehicle vehicle in Program.garage)
                    {
                        Console.WriteLine(vehicle);
                        Console.WriteLine("------------------");
                    }
                    break;
                case 3:
                    return true;
                default:
                    Console.WriteLine("Try again!");
                    break;
            }
            Console.ReadLine();
            return false;
        }

        public override Menu ShowMenu()
        {
            Console.WriteLine("What do you want to do?" +
                "\n1. Save current garage" +
                "\n2. Open saved garage" +
                "\n3. Go back to main menu");
            while(!HandleInput())
            {
                Console.WriteLine("Select one of the menu options to continue");
            }
            return new MainMenu();
        }
    }
}
