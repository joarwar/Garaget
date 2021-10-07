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
            int vehiclepark = Console.ReadLine();

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
                Console.WriteLine("Argh! Please try again! Type one of the vehicles: \n1.Motorcycle"
                          + "\n2. Car"
                          + "\n3. Bus"
                          + "\n4. Truck"
                          + "\n5. Plane"
                          + "\n0. Back to Main menu");

                
            }
            return null;

        }


        public override bool HandleInput()
        {


            private void ParkPlane()
            {
                Object[] basicValues = SetBasicValues();
                Console.WriteLine("How many wings does your plane have?");
                uint PlaneWings;
                while (!uint.TryParse(Console.ReadLine(), out PlaneWings))
                {

                }
                Console.WriteLine("Is it a private plane?");
                bool IsPrivate;
                while (!bool.TryParse(Console.ReadLine(), out IsPrivate))
                {

                }
                Plane myPlane = new Plane(PlaneWings, IsPrivate, basicValues[0]);
            }

            private void ParkTruck()
            {
                Object[] basicValues = SetBasicValues();
                Console.WriteLine("Is it a pickup?");
                bool IsPickup;
                while (!bool.TryParse(Console.ReadLine(), out IsPickup))
                {

                }
                Console.WriteLine("From what year is the truck from?");
                uint TruckYear;
                while (!uint.TryParse(Console.ReadLine(), out TruckYear))
                {

                }
                Truck myTruck = new Truck(IsPickup, TruckYear, basicValues[0]);
            }

            private void ParkBus()
            {
                Object[] basicValues = SetBasicValues();
                Console.WriteLine("Is it a school bus?");
                bool IsSchoolbus;
                while (!bool.TryParse(Console.ReadLine(), out IsSchoolbus))
                {

                }

                Console.WriteLine("How many floors does your bus have?");
                uint Floor;
                while (!bool.TryParse(Console.ReadLine(), out Floor))
                {

                }
                Bus myBus = new Bus(IsSchoolbus, Floor, basicValues[0]);
            }

            private void ParkCar()
            {

                Object[] basicValues = SetBasicValues();
                Console.WriteLine("What fuel does your car use?");
                string Fuel = Console.ReadLine();

                Console.WriteLine("Is your car a cabriolet?");
                bool IsCabriolet;
                while (!bool.TryParse(Console.ReadLine(), out IsCabriolet))
                {

                }
                Car myCar = new Car(Fuel, IsCabriolet, basicValues[0]);
            }

            private void ParkMotorcycle()
            {
                Object[] basicValues = SetBasicValues();
                Console.WriteLine("What did your motorcycle cost in dollars?");
                uint Price;
                while (!bool.TryParse(Console.ReadLine(), out Price))
                {

                }
                Console.WriteLine("How fast does your motorcycle go in km/h?");
                string Km = Console.ReadLine();
                Motor myMotor = new Motor(Price, Km, basicValues[0]);
            }

            private Object[] SetBasicValues()
            {
                var array = new Object[5];
                Console.WriteLine("How many tires does you vehicles have?");

                uint VehicleTires;
                while (!uint.TryParse(Console.ReadLine(), out VehicleTires))
                {

                }
                array[0] = VehicleTires;

                Console.WriteLine("What registration number does your vehicle have?");
                string Reg = Console.ReadLine();
                array[1] = Reg;
                Console.WriteLine("What color is it?");
                string Color = Console.ReadLine();
                array[2] = Color;
                Console.WriteLine("How many people fit in your vehicle?");
                uint Space;
                while (!uint.TryParse(Console.ReadLine(), out Space))
                {

                }
                array[3] = Space;
                Console.WriteLine("What make is your vehicle?");
                string Make = Console.ReadLine();
                array[4] = Make;

                return array;
                //return MainMenu;
              
            }

        }
    }
}
