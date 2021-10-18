using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget
{
    class ListTypesOfVehiclesMenu : Menu
    {
        public override Menu GetNextMenu(int input)
        {
            return new MainMenu();
        }

        public override int HandleInput()
        {
            Console.ReadLine();
            return 0;
        }

        public override void ShowMenu()
        {
            
            if (Program.garage.Count == 0)
            {
                Console.WriteLine("There are currently no vehicles in the garage, come back when a few have parked");
            }
            else
            {
                Console.WriteLine("Types of vehicles currently in the garage:");
                foreach (var item in Program.garage.ListTypesOfVehicles())
                {
                   
                    Console.WriteLine(item);
                    
                }
            }
            Console.WriteLine("Press any key to get to the main menu");
        }
    }
}
