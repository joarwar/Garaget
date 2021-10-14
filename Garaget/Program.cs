using System;

namespace Garaget
{
    class Program
    {
        public static Garage<Vehicle> garage;
        public static string path = "savedgarage.json";

        static void Main(string[] args)
        {
            garage = new Garage<Vehicle>(20);
            garage.AddVehicle(new Car(3, "sak222", "green", 5, "tot", "gas", false));
            garage.AddVehicle(new Bus(3, "sok332", "green", 5, "tot", true, 2));
            garage.AddVehicle(new Motorcycle(3, "bool70", "green", 5, "tot", 1000, 2));
            garage.AddVehicle(new Truck(3, "ouy055", "green", 5, "tot", false, 5));
            garage.AddVehicle(new Plane(3, "mim794", "green", 5, "tot", 5, false));

            Menu currentMenu = new MainMenu();
            //Menu currentMenu = new GarageCreationMenu();
            while (true)
            {
                Console.Clear();
                currentMenu = currentMenu.ShowMenu();
            }

        }
    }
}
