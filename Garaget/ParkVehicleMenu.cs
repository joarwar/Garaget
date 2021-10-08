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
            while (!HandleInput())
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


        public override bool HandleInput()
        {
            int vehiclepark = ParseInput(Console.ReadLine(), 5);

            if (vehiclepark == 1)
            {
                ParkMotorcycle();

            }
            else if (vehiclepark == 2)
            {
                ParkCar();

            }
            else if (vehiclepark == 3)
            {
                ParkBus();

            }
            else if (vehiclepark == 4)
            {
                ParkTruck();
            }
            else if (vehiclepark == 5)
            {
                ParkPlane();
            }
            else
            {

                return false;
            }
            return true;



        }

        private void ParkPlane()
        {
            Object[] basicValues = SetBasicValues();
            Console.WriteLine("How many wings does your plane have?");
            uint planeWings;
            while (!uint.TryParse(Console.ReadLine(), out planeWings))
            {

            }
            Console.WriteLine("Is it a private plane?");
            bool isPrivate;
            while (!bool.TryParse(Console.ReadLine(), out isPrivate))
            {

            }
            Plane myPlane = new Plane(planeWings, isPrivate, basicValues[0]);
        }

        private void ParkTruck()
        {
            Object[] basicValues = SetBasicValues();
            Console.WriteLine("Is it a pickup?");
            bool isPickup;
            while (!bool.TryParse(Console.ReadLine(), out isPickup))
            {

            }
            Console.WriteLine("From what year is the truck from?");
            uint truckYear;
            while (!uint.TryParse(Console.ReadLine(), out truckYear))
            {

            }
            Truck myTruck = new Truck(isPickup, truckYear, basicValues[0]);
        }

        private void ParkBus()
        {
            Object[] basicValues = SetBasicValues();
            Console.WriteLine("Is it a school bus?");
            bool isSchoolbus;
            while (!bool.TryParse(Console.ReadLine(), out isSchoolbus))
            {

            }

            Console.WriteLine("How many floors does your bus have?");
            uint floor;
            while (!bool.TryParse(Console.ReadLine(), out floor))
            {

            }
            Bus myBus = new Bus(isSchoolbus, floor, basicValues[0]);
        }

        private void ParkCar()
        {

            Object[] basicValues = SetBasicValues();
            Console.WriteLine("What fuel does your car use?");
            string fuel = Console.ReadLine();

            Console.WriteLine("Is your car a cabriolet?");
            bool isCabriolet;
            while (!bool.TryParse(Console.ReadLine(), out isCabriolet))
            {

            }
            Car myCar = new Car(fuel, isCabriolet, basicValues[0]);
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
    }
}
