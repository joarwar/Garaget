using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget
{
    class ParkVehicleMenu : Menu
    {
        public override Menu ShowMenu()
        {

            Console.WriteLine("Type the vehicle would you like to park?"
                          + "\n1. Motorcycle"
                          + "\n2. Car"
                          + "\n3. Bus"
                          + "\n4. Truck"
                          + "\n5. Plane"
                          + "\n0. Back to Main menu");
            // Handle input
            string vehiclepark = Console.ReadLine();

            if (vehiclepark == "Motorcycle")
            {
                ParkMotorcycle();

            }
            else if (vehiclepark == "Car")
            {
                ParkCar();

            }
            else if (vehiclepark == "Bus")
            {
                ParkBus();

            }
            else if (vehiclepark == "Truck")
            {
                ParkTruck();
            }
            else if (vehiclepark == "Plane")
            {
                ParkPlane();
            }
            else 
            {
                Console.WriteLine("Argh! Please try again! Type one of the vehicles: \n1.Motorcycle"
                          + "\n2. Car"
                          + "\n3. Bus"
                          + "\n4. Truck"
                          + "\n5. Plane"
                          + "\n0. Back to Main menu");
            }

            return new MainMenu();
        }

        private void ParkPlane()
        {
            Object[] basicValues = SetBasicValues();           
            Console.WriteLine("How many wings does your plane have?");
            uint planewings;
            while (!uint.TryParse(Console.ReadLine(), out planewings))
            {

            }
            Console.WriteLine("Is it a private plane?");          
            bool isprivate;
            while (!bool.TryParse(Console.ReadLine(), out isprivate))
            {

            }
            Plane myPlane = new Plane(planewings, isprivate, basicValues[0]);
        }

        private void ParkTruck()
        {
            Object[] basicValues = SetBasicValues();
            Console.WriteLine("Is it a pickup?");
            bool ispickup;
            while (!bool.TryParse(Console.ReadLine(), out ispickup))
            {

            }
            Console.WriteLine("From what year is the truck from?"); 
            uint truckyear;
            while (!uint.TryParse(Console.ReadLine(), out truckyear))
            {

            }
            Truck myTruck = new Truck(ispickup, truckyear, basicValues[0]);
        }

        private void ParkBus()
        {
            Object[] basicValues = SetBasicValues();
            Console.WriteLine("Is it a school bus?");
            bool isschoolbus;
            while (!bool.TryParse(Console.ReadLine(), out isschoolbus))
            {

            }

            Console.WriteLine("How many floors does your bus have?");
            uint floor;
            while (!bool.TryParse(Console.ReadLine(), out floor))
            {

            }
            Bus myBus = new Bus(isschoolbus, floor, basicValues[0]);
        }

        private void ParkCar()
        {

            Object[] basicValues = SetBasicValues();
            Console.WriteLine("What fuel does your car use?");
            string fuel = Console.ReadLine();
            Console.WriteLine("Is your car a cabriolet?");
            bool iscabriolet;
            while (!bool.TryParse(Console.ReadLine(), out iscabriolet))
            {

            }
            Car myCar = new Car(fuel, iscabriolet, basicValues[0]);
        }

        private void ParkMotorcycle()
        {
            Object[] basicValues = SetBasicValues();
            Console.WriteLine("What did your motorcycle cost in dollars?");
            uint price;
            while (!bool.TryParse(Console.ReadLine(), out price))
            {

            }
            Console.WriteLine("How fast does your motorcycle go in km/h?");
            string km = Console.ReadLine();
            Motor myMotor = new Motor(price, km, basicValues[0]);
        }

        private Object[] SetBasicValues()
        {
            var array = new Object[5];
            Console.WriteLine("How many tires does you vehicles have?");
           
            uint vehicletires;
            while (!uint.TryParse(Console.ReadLine(), out vehicletires))
            {

            }
            array[0] = vehicletires;
            Console.WriteLine("What registration number does your vehicle have?");
            string reg = Console.ReadLine();
            array[1] = reg;
            Console.WriteLine("What color is it?");
            string color = Console.ReadLine();
            array[2] = color;
            Console.WriteLine("How many people fit in your vehicle?");          
            uint space;
            while (!uint.TryParse(Console.ReadLine(), out space))
            {

            }
            array[3] = space;
            Console.WriteLine("What make is your vehicle?");
            string make = Console.ReadLine();
            array[4] = make;
           
            return array;
        }

        public override bool HandleInput()
        {
            throw new NotImplementedException();
        }
    }
}
