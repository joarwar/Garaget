using System;

namespace Garaget
{
    class MainMenu : Menu
    {
        public override void ShowMenu()
        {      
            Console.WriteLine("What do you want to do?"
                    + "\n1. Create a garage."
                    + "\n2. Park vehicle." // also creates vehicle
                    + "\n3. List vehicles." // show created vehicles
                    + "\n4. Search vehicles." // searches all vehicles through properties
                    + "\n5. Depart vehicle from garage." // removes vehicle from garage
                    + "\n6. Save or Load garages." 
                    + "\n7. Exit application");
        }

        public override int HandleInput()
        {
            int input;
            while(!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > 7)
            {
                Console.WriteLine("Input does not correspond to a menu option");
            }
            return input;
        }

        public override Menu GetNextMenu(int input)
        {
            switch(input)
            {
                case 1:
                    return new GarageCreationMenu();
                case 2:
                    return new ParkVehicleMenu();
                case 3:
                    return new ListVehiclesMenu();
                case 4:
                    return new SearchVehiclesMenu();
                case 5:
                    return new DepartVehicleMenu();
                case 6:
                    return new SaveLoadMenu();
                case 7:
                    return new ExitMenu();
                default:
                    return null;
            }
        }
    }
}
