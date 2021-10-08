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
                          + "\n6. Back to Main menu");
            while (!HandleInput())
            {
                Console.WriteLine("Argh! Please try again! Type one of the vehicles:\n1. Motorcycle"
                + "\n2. Car"
                + "\n3. Bus"
                + "\n4. Truck"
                + "\n5. Plane"
                + "\n6. Back to Main menu");
            }


            return new MainMenu();

        }

        public override bool HandleInput()
        {
            do
            {

                int parkMenu = ParseInput(Console.ReadLine(), 6);
                switch (parkMenu)
                {
                    case 1:
                        ParkMotorcycle();
                        break;
                    case 2:
                        ParkCar();
                        break;
                    case 3:
                        ParkBus();
                        break;
                    case 4:
                        ParkTruck();
                        break;
                    case 5:
                        ParkPlane();
                        break;
                    case 6:
                        return true;
                    default:
                        
                        cont = false;
                        break;
                }

               
            } while (cont);
            return false;


        }

        private void ParkPlane()
        {


            Console.WriteLine("How many wings does your plane have?");
            uint planeWings;
            while (!uint.TryParse(Console.ReadLine(), out planeWings))
            {
                Console.WriteLine("Please only write numbers!");
            }
            Console.WriteLine("Is it a private plane? (True/False)");
            bool isPrivate;
            while (!bool.TryParse(Console.ReadLine(), out isPrivate))
            {
                Console.WriteLine("Please specify through either true or false.");
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

            Console.WriteLine("Is it a pickup? (True/False)");
            bool isPickup;
            while (!bool.TryParse(Console.ReadLine(), out isPickup))
            {
                Console.WriteLine("Please specify through either true or false.");
            }
            Console.WriteLine("From what year is the truck from?");
            int truckYear;
            while (!int.TryParse(Console.ReadLine(), out truckYear))
            {
                Console.WriteLine("Please only write numbers!");
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
            Console.WriteLine("Is it a school bus? (True/False)");
            bool isSchoolbus;
            while (!bool.TryParse(Console.ReadLine(), out isSchoolbus))
            {
                Console.WriteLine("Please specify through either true or false.");
            }

            Console.WriteLine("How many floors does your bus have?");
            uint floor;
            while (!uint.TryParse(Console.ReadLine(), out floor))
            {
                Console.WriteLine("Please only write numbers highter than 0!");
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

            Console.WriteLine("Is your car a cabriolet? (True/False)");
            bool isCabriolet;
            while (!bool.TryParse(Console.ReadLine(), out isCabriolet))
            {
                Console.WriteLine("Please specify through either true or false.");
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
            decimal price;
            while (!decimal.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Please only write numbers!");
            }
            Console.WriteLine("How fast does your motorcycle go in km/h?");
            uint cylinder;
            while (!uint.TryParse(Console.ReadLine(), out cylinder))
            {
                Console.WriteLine("Please only write numbers highter than 0!");
            }
            Motorcycle myMotor = new Motorcycle(
                 GetTires(),
                 GetRegisterNumber(),
                 GetColor(),
                 GetSpace(),
                 GetBrand(),
                 price, cylinder);
            Program.garage.AddVehicle(myMotor);
        }

        private uint GetTires()
        {
            Console.WriteLine("How many tires does you vehicles have?");

            uint vehicleTires;
            while (!uint.TryParse(Console.ReadLine(), out vehicleTires))
            {
                Console.WriteLine("Please only write numbers highter than 0!");
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
                Console.WriteLine("Please only write numbers highter than 0!");
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

