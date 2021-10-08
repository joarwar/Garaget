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
            Plane myPlane = new Plane(
                GetTires(),
                GetRegisterNumber(),
                GetColor(),
                GetSpace(),
                GetBrand(),
                planeWings, isPrivate);
            Program.garage.AddVehicle(myPlane);
        }

        private void ParkTruck()
        {

            Console.WriteLine("Is it a pickup?");
            bool isPickup;
            while (!bool.TryParse(Console.ReadLine(), out isPickup))
            {

            }
            Console.WriteLine("From what year is the truck from?");
            int truckYear;
            while (!int.TryParse(Console.ReadLine(), out truckYear))
            {

            }
            Truck myTruck = new Truck(
                    GetTires(),
                    GetRegisterNumber(),
                    GetColor(),
                    GetSpace(),
                    GetBrand(),
                    isPickup, truckYear);
            Program.garage.AddVehicle(myTruck);


        }

        private void ParkBus()
        {
            Console.WriteLine("Is it a school bus?");
            bool isSchoolbus;
            while (!bool.TryParse(Console.ReadLine(), out isSchoolbus))
            {

            }

            Console.WriteLine("How many floors does your bus have?");
            int floor;
            while (!int.TryParse(Console.ReadLine(), out floor))
            {

            }
            Bus myBus = new Bus(
                 GetTires(),
                 GetRegisterNumber(),
                 GetColor(),
                 GetSpace(),
                 GetBrand(),
                 isSchoolbus, floor);
            Program.garage.AddVehicle(myBus);

            

        }

        private void ParkCar()
        {
            
            Console.WriteLine("What fuel does your car use?");
            string fuel = Console.ReadLine();

            Console.WriteLine("Is your car a cabriolet?");
            bool isCabriolet;
            while (!bool.TryParse(Console.ReadLine(), out isCabriolet))
            {

            }
            Car myCar = new Car(
                 GetTires(),
                 GetRegisterNumber(),
                 GetColor(),
                 GetSpace(),
                 GetBrand(),
                 fuel, isCabriolet);
            Program.garage.AddVehicle(myCar);
                
                
        }

        private void ParkMotorcycle()
        {
            Console.WriteLine("What did your motorcycle cost in dollars?");
            uint price;
            while (!uint.TryParse(Console.ReadLine(), out price))
            {

            }
            Console.WriteLine("How fast does your motorcycle go in km/h?");
            string km = Console.ReadLine();
            Motorcycle myMotor = new Motorcycle(
                 GetTires(),
                 GetRegisterNumber(),
                 GetColor(),
                 GetSpace(),
                 GetBrand(),
                 km, price);
            Program.garage.AddVehicle(myMotor);
        }

        private uint GetTires()
        {
            Console.WriteLine("How many tires does you vehicles have?");

            uint vehicleTires;
            while (!uint.TryParse(Console.ReadLine(), out vehicleTires))
            {

            }
            return vehicleTires;
        }

        private string GetRegisterNumber()
        {
            Console.WriteLine("What registration number does your vehicle have?");

            return Console.ReadLine();

        }

        private string GetColor()
        {
            Console.WriteLine("What color is it?");
            return Console.ReadLine();
        }

        private uint GetSpace()
        {
            Console.WriteLine("How many people fit in your vehicle?");
            uint space;
            while (!uint.TryParse(Console.ReadLine(), out space))
            {

            }
            return space;
        }
        private string GetBrand()
        {
            Console.WriteLine("What brand is your vehicle?");
            return Console.ReadLine();
        }
    }
}
}
