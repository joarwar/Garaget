using Garaget.FileManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget
{
    class SaveLoadMenu : Menu
    {
        public override bool HandleInput()
        {
            JSONWrapper wrapper = new JSONWrapper();

            string filePath = "savedgarage.json";
            int saveLoadMenu = ParseInput(Console.ReadLine(), 3);
            switch (saveLoadMenu)
            {
                case 1:
                    wrapper.SaveState(filePath, Program.garage);
                    break;
                case 2:
                   // Program.garage = wrapper.RestoreState<Garage<Vehicle>>(filePath);
                    break;
                case 3:
                    return true;
                default:
                    Console.WriteLine("Try again!");
                    break;
            }
            Console.WriteLine("Press any key to continue....");
            Console.ReadLine();
            return false;
        }


        public override Menu ShowMenu()
        {
            Console.WriteLine("What do you want to do?" +
                "\n1. Saved current garage" +
                "\n2. Open saved garages" +
                "\n3. Go back to main menu");
            HandleInput();
            return new MainMenu();

        }
        
             
        
    }
}
