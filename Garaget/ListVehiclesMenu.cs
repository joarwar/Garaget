using System;

namespace Garaget
{
    class ListVehiclesMenu : Menu
    {
        public override void ShowMenu()
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
            Console.WriteLine("Press any key to get to the main menu");
        }

        public override int HandleInput()
        {
            Console.ReadLine();
            return 0;
        }

        public override Menu GetNextMenu(int input)
        {
            return new MainMenu();
        }
    }
}
