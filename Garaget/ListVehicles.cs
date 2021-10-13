using System;

namespace Garaget
{
    class ListVehicles : Menu
    {
        public override bool HandleInput()
        {
            Console.WriteLine("Press any key to get to the main menu");
            Console.ReadLine();
            return true;
        }

        public override Menu ShowMenu()
        {
            foreach (var item in Program.garage.vehicles)
            {
                Console.WriteLine(item);
                Console.WriteLine("-------------------------------");
            }

            HandleInput();
            return new MainMenu();
        }
    }
}
