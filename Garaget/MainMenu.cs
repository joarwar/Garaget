using System;

namespace Garaget
{
    class MainMenu : Menu
    {
        public override Menu ShowMenu()
        {      
            Console.WriteLine("What do you want to do?"
                    + "\n1. Create a garage."
                    + "\n2. Park vehicle." // also creates vehicle
                    + "\n3. List vehicles." // show created vehicles
                    + "\n4. Search vehicles." // searches all vehicles through properties
                    + "\n5. Depart vehicle from garage." // removes vehicle from garage
                    + "\n6. Save or Load garages." 
                    + "\n7. Exit application");

            do
            {
                int caseMenu = ParseInput(Console.ReadLine(), 7);
                switch (caseMenu)
                {
                    case 1:
                        return new GarageCreationMenu();
                    case 2:
                        return new ParkVehicleMenu();                      
                    case 3:
                        return new ListVehicles();
                    case 4:
                        return new SearchVehiclesMenu();
                    case 5:
                        return new DepartVehicleMenu();
                    case 6:
                        return new SaveLoadMenu();
                    case 7:
                        return new ExitMenu();
                    default:
                        Console.WriteLine("Skriv gärna en siffra mellan 1-5.");
                        break;

                }

            } while (cont == true);

            return null;
        }


        public override bool HandleInput()
        {
            
            Console.ReadLine();
            return true;
        }
    }
}
