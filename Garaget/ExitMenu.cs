using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget
{
    class ExitMenu : Menu
    {
        //public int AmountOfMenuItems { get; set; }
        //public Menu NextMenu { get; set; }
        ////tänka om
        //public ExitMenu()
        //{
        //    AmountOfMenuItems = 1;
        //}

        public override Menu ShowMenu()
        {
            Console.WriteLine("Thank you for using our garage");
            HandleInput();
            return null;
        }

        public override bool HandleInput()
        {
            Program.garage.SaveState(Program.path);
            Environment.Exit(0);
            return false;
        }

    }
}
