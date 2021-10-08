using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            foreach (var item in Program.garage._vehicles)
            {
                Console.WriteLine(item);
            }

            HandleInput();
            return new MainMenu();
        }
    }
}
