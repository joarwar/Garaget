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

          
            return new MainMenu();
        }

        public override bool HandleInput()
        {
            //når inte listan
            Vehicles.ForEach(Console.WriteLine);
            types.RemoveAt(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Drive safely!");

            return true;

        }
    }
}
