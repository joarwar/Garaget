using System;

namespace Garaget
{
    class ListVehiclesMenu : Menu
    {
        public override bool HandleInput()
        {
            Console.WriteLine("Press any key to get to the main menu");
            Console.ReadLine();
            return true;
        }

        public override Menu ShowMenu()
        {
            if(Program.garage.Count == 0)
            {
                Console.WriteLine("There are currently no vehicles in the garage, come back when a few have parked");
            }
            else
            {
                foreach (var item in Program.garage.vehicles)
                {
                    Console.WriteLine(item);
                    Console.WriteLine("-------------------------------");
                }
            }

            HandleInput();
            return new MainMenu();
        }
    }
}
