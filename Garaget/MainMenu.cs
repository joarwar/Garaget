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
                                + "\n1. Park vehicle." // also creates vehicle
                                + "\n2. List vehicles." // show created vehicles
                                + "\n3. Search vehicles." // searches all vehicles through properties
                                + "\n4. Depart vehicle from garage." // removes vehicle from garage
                                + "\n0. Exit application.");
            HandleInput();
            return new ParkVehicleMenu();
        }

        public override bool HandleInput()
        {
            Console.WriteLine("INPUT!!!");
            Console.ReadLine();
            return true;
        }
    }
}
