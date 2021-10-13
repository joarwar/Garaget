using System;

namespace Garaget
{
    class DepartVehicleMenu : Menu
    {

        public override Menu ShowMenu()
        {
            Console.WriteLine("Type the number of the vehicle you would like to take out?");
            for (int vehicleIndex = 0; vehicleIndex < Program.garage.Count; vehicleIndex++)
            {
                var item = Program.garage[vehicleIndex];
                Console.WriteLine((vehicleIndex + 1) + ". " + item.RegisterNumber + " " + item.GetType().Name);
            }
            HandleInput();
            Console.WriteLine("Press any key to continue.....");
            Console.ReadLine();
            
            return new MainMenu();
        }

        public override bool HandleInput()
        {

            do
            {

                int departMenu = ParseInput(Console.ReadLine(), Program.garage.Count);
                if (departMenu > 0 && departMenu <= Program.garage.Count)

                {
                    Console.WriteLine(Program.garage[departMenu - 1]);
                    Program.garage.RemoveVehicle(Program.garage[departMenu - 1]);
                    //remove vehicle
                    cont = false;

                }
                else
                {
                    Console.WriteLine("Value not accepted, try again");
                }
               
            } while (cont);

            Console.WriteLine("\nDrive safely!");

            return true;

        }
    }
}
