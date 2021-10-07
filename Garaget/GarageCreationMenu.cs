using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget
{
    class GarageCreationMenu : Menu
    {
        public override Menu ShowMenu()
        {
            Console.WriteLine("Garage creation\n"
                +"How many parking spots are there in the garage you wish to create?");

            Console.ReadLine();
            Console.WriteLine("You've now made a garage with " + input + " spots.");
            return new MainMenu();
        }

        public override bool HandleInput()
        {
            uint input;
            while(!uint.TryParse(Console.ReadLine(), out input))
            {
                
            }

            Program.garage = new Garage<Vehicles>(input);

            return true;

        }

        
    }
}
