using System;

namespace Garaget
{
    class Program
    {
        public static Garage<Vehicle> garage;

        static void Main(string[] args)
        {
            
            Menu currentMenu = new GarageCreationMenu();
            while(true)
            {
                //Console.Clear();
                currentMenu = currentMenu.ShowMenu();
            }
        }
    }
}
