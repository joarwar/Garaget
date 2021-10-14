using System;

namespace Garaget
{
    class GarageCreationMenu : Menu
    {
        public override void ShowMenu()
        {
            Console.WriteLine("Garage creation\n"
                +"How many parking spots are there in the garage you wish to create?");
        }

        public override int HandleInput()
        {
            uint input;

            while(!uint.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please write a positivt whole number");
            }

            Program.garage = new Garage<Vehicle>(input);

            Console.WriteLine("You've now made a garage with " + input + " spots.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            return 0;

        }

        public override Menu GetNextMenu(int input)
        {
            return new MainMenu();
        }
    }
}
