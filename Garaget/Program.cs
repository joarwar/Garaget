using System;

namespace Garaget
{
    class Program
    {
        public static Garage<Vehicle> garage;

        static void Main(string[] args)
        {
            garage = new Garage<Vehicle>(20);
            garage.AddVehicle(new Car(3, "sak222", "green", 5, "tot", "gas", false));
            garage.AddVehicle(new Car(3, "sok332", "green", 5, "tot", "gas", false));
            garage.AddVehicle(new Car(3, "bool70", "green", 5, "tot", "gas", false));
            garage.AddVehicle(new Car(3, "ouy055", "green", 5, "tot", "gas", false));
            garage.AddVehicle(new Car(3, "mim794", "green", 5, "tot", "gas", false));

            Menu currentMenu = new MainMenu();
            while(true)
            {
                //Console.Clear();
                currentMenu = currentMenu.ShowMenu();
            }
        }
    }
}
