using System;

namespace Garaget
{
    class ParkVehicleMenu : Menu
    {
        public int Brand { get; private set; }
        public string Color { get; private set; }

        public override void ShowMenu()
        {
            Console.WriteLine("What vehicle would you like to park?"
                          + "\n1. Park motorcycle"
                          + "\n2. Park car"
                          + "\n3. Park bus"
                          + "\n4. Park truck"
                          + "\n5. Park plane"
                          + "\n6. Back to Main menu");
        }

        public override int HandleInput()
        {
            int input;
            while(!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > 6)
            {
                Console.WriteLine("Input does not correspond to a menu option");
            }

            ParkVehicle(input);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            return input;
        }

        private void ParkVehicle(int input)
        {
            switch(input)
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
                default:
                    break;
            }
        }

        public override Menu GetNextMenu(int input)
        {
            if(input == 6)
            {
                return new MainMenu();
            }
            return this;
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
            Console.WriteLine("You have created a plane with these properties:\n" + myPlane);
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
            Console.WriteLine("You have created a truck with these properties:\n" + myTruck);
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
                Console.WriteLine("Please only write numbers higher than 0!");
            }
            Bus myBus = new Bus(
                 GetTires(),
                 GetRegisterNumber(),
                 GetColor(),
                 GetSpace(),
                 GetBrand(),
                 isSchoolbus, floor);
            Console.WriteLine("You have created a bus with these properties:\n" + myBus);
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
            Console.WriteLine("You have created a car with these properties:\n" + myCar);
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
            Console.WriteLine("How many cylinders does your motorcycle have?");
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
            Console.WriteLine("You have created a motorcycle with these properties:\n" + myMotor);
            Program.garage.AddVehicle(myMotor);
        }

        public uint GetTires()
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

