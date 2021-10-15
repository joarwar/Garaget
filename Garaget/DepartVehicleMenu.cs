using System;

namespace Garaget
{
    class DepartVehicleMenu : Menu
    {

        public override void ShowMenu()
        {
            if (Program.garage.Count == 0)
            {
                Console.WriteLine("There are no vehicles in the garage");
                Console.WriteLine("Type 1 to go back.");
                return;
            }
            Console.WriteLine("Type the number of the vehicle you would like to take out?");
                

            
            for (int vehicleIndex = 0; vehicleIndex < Program.garage.Count; vehicleIndex++)
            {
                var item = Program.garage[vehicleIndex];
                Console.WriteLine((vehicleIndex + 1) + ". " + item.RegisterNumber + " " + item.GetType().Name);

                if (vehicleIndex == Program.garage.Count - 1)
                {
                    Console.WriteLine(vehicleIndex + 2 + ". Return to main menu" );
                        
                }

            }
            
        }

        public override int HandleInput()
        {
            int input;
            while(!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > Program.garage.Count + 1)
            {
                Console.WriteLine("Input does not correspond to a menu option");
            }

            if (input <= Program.garage.Count)
            {
                DepartVehicle(input);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            return input;
        }

        public override Menu GetNextMenu(int input)
        {
            if(input == Program.garage.Count + 1)
            {
                return new MainMenu();
            }
            return this;
        }

        private static void DepartVehicle(int input)
        {
            Console.WriteLine("\nThis vehicle is the one to depart:");
            Console.WriteLine(Program.garage[input - 1]);
            Console.WriteLine("\nDrive safely!");
            Program.garage.RemoveVehicle(Program.garage[input - 1]);
        }
    }
}
