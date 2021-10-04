using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    + "\n6. Exit application.");
                //HandleInput();
                //return new ParkVehicleMenu();


            
            do
            {
                int casemenu = ParseInput(Console.ReadLine(), 4);
                switch (casemenu)
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
                        cont = false;
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
            Console.WriteLine("INPUT!!!");
            Console.ReadLine();
            return true;
        }
    }
}
