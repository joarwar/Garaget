using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget
{
    class DepartVehicleMenu : Menu
    {

        public override Menu ShowMenu()
        {
            Console.WriteLine("What vehicle would you like to take out?");

          
            
            
            foreach (var item in Program.garage._vehicles)
            {
                Console.WriteLine(item.RegisterNumber);               
            }
            return new MainMenu();
        }

        public override bool HandleInput()
        {
            //når inte listan

            //Program.garage.RemoveVehicle(Program.garage._vehicles.Select);    
            //types.RemoveAt(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Drive safely!");

            return true;

        }
    }
}
