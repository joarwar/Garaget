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
            
            // Alternativ göra en array istället för att skapa flera fordon.
            if (vehiclepark == "Motorcycle")
            {
                
                Motor myMotor = new Motor();
                Console.WriteLine("How many tires does you motorcycle have?");
                myMotor.tires = Console.ReadLine();
                Console.WriteLine("What registration number does your motorcycle have?");
                myMotor.reg = Console.ReadLine();
                Console.WriteLine("What color is it?");
                myMotor.color = Console.ReadLine();
                Console.WriteLine("How many people fit in your motorcycle?");
                myMotor.space = Console.ReadLine();
                Console.WriteLine("What make is your motorcycle?");
                myMotor.make = Console.ReadLine();
                Console.WriteLine("What did your motorcycle cost in dollars?");
                myMotor.price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How fast does your motorcycle go in km/h?");
                myMotor.speed = Convert.ToInt32(Console.ReadLine());


            }
            else if (vehiclepark == "Car")
            {
                Car myCar = new Car();
                Console.WriteLine("How many tires does you car have?");
                myCar.tires = Console.ReadLine();
                Console.WriteLine("What registration number does your car have?");
                myCar.reg = Console.ReadLine();
                Console.WriteLine("What color is it?");
                myCar.color = Console.ReadLine();
                Console.WriteLine("How many people fit in your car?");
                Console.WriteLine("What make is your car?");
                myCar.make = Console.ReadLine();
                myCar.space = Console.ReadLine();
                Console.WriteLine("What fuel does your car use?");
                myCar.fuel = Console.ReadLine();
                Console.WriteLine("Is your car a cabriolet?");
                myCar.iscabriolet = Console.ReadLine();

            }
            else if (vehiclepark == "Bus")
            {
                Bus myBus = new Bus();
                Console.WriteLine("How many tires does your bus have");
                myBus.tires = Console.ReadLine();
                Console.WriteLine("What registration number does your bus have?");
                myBus.reg = Console.ReadLine();
                Console.WriteLine("What color is it?");
                myBus.color = Console.ReadLine();
                Console.WriteLine("How many people fit in your bus?");
                myBus.space = Console.ReadLine();
                Console.WriteLine("What make is your bus?");
                myBus.make = Console.ReadLine();
                Console.WriteLine("Is it a school bus?");
                myBus.isschoolbus = Console.ReadLine();
                Console.WriteLine("How many floors does your bus have?");
                myBus.floor = Console.ReadLine();

            }
            else if (vehiclepark == "Truck")
            {
                Truck myTruck = new Truck();
                Console.WriteLine("How many tires does your truck have");
                myTruck.tires = Console.ReadLine();
                Console.WriteLine("What registration number does your truck have?");
                myTruck.reg = Console.ReadLine();
                Console.WriteLine("What color is it?");
                myTruck.color = Console.ReadLine();
                Console.WriteLine("How many people fit in your truck?");
                myTruck.space = Console.ReadLine();
                Console.WriteLine("What make is your truck?");
                myTruck.make = Console.ReadLine();
                Console.WriteLine("Is it a pickup?");
                myTruck.ispickup = Console.ReadLine();
                Console.WriteLine("From what year is the truck from?");
                myTruck.floor = Console.ReadLine();
            }
            else if (vehiclepark == "Plane")
            {
                Plane myPlane = new Plane();
                Console.WriteLine("How many tires does your plane have");
                myPlane.tires = Console.ReadLine();
                Console.WriteLine("What registration number does your plane have?");
                myPlane.reg = Console.ReadLine();
                Console.WriteLine("What color is it?");
                myPlane.color = Console.ReadLine();
                Console.WriteLine("How many people fit in your plane?");
                myPlane.space = Console.ReadLine();
                Console.WriteLine("What make is your plane?");
                myPlane.make = Console.ReadLine();
                Console.WriteLine("How many wings does your plane have?");
                myPlane.wings = Console.ReadLine();
                Console.WriteLine("Is it a private plane?");
                myPlane.isprivate = Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Argh! Please try again!");
            }

            return new MainMenu();
        }

        public override bool HandleInput()
        {
            throw new NotImplementedException();
        }
    }
}
