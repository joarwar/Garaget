using System;

namespace Garaget
{
    class SaveLoadMenu : Menu
    {
        public override void ShowMenu()
        {
            Console.WriteLine("What do you want to do?" +
                "\n1. Save current garage" +
                "\n2. Open saved garage" +
                "\n3. Go back to main menu");
        }

        public override int HandleInput()
        {
            int input;
            while(!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > 3)
            {
                Console.WriteLine("Input does not correspond to a menu option");
            }

            switch(input)
            {
                case 1:
                    SaveGarageToFile();
                    break;
                case 2:
                    LoadGarageFromFile();
                    ListVehicles();
                    break;
                default:
                    break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            return input;
        }

        public override Menu GetNextMenu(int input)
        {
            if(input == 3)
            {
                return new MainMenu();
            }
            return this;
        }

        private static void LoadGarageFromFile()
        {
            Garage<Vehicle>.RestoreState(Program.path);
            Console.WriteLine("Garage loaded with the following vehicles:\n");
        }

        private static void SaveGarageToFile()
        {
            Program.garage.SaveState(Program.path);
            Console.WriteLine("Garage saved");
        }

        private static void ListVehicles()
        {
            foreach(Vehicle vehicle in Program.garage)
            {
                Console.WriteLine(vehicle);
                Console.WriteLine("------------------");
            }
        }
    }
}
