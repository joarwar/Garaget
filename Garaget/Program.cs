using System;

namespace Garaget
{
    class Program
    {
        public static Garage<Vehicles> garage;
        static void Main(string[] args)
        {
            Menu currentMenu = new MainMenu();
            while(true)
            {
                Console.Clear();
                currentMenu = currentMenu.ShowMenu();
            }
        }
    }
}
