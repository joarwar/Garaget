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

            }
            else if (vehiclepark == "Bus")
            {
                Bus myBus = new Bus();
                
            }
            else if (vehiclepark == "Truck")
            {
                Truck myTruck = new Truck();
            }
            else if (vehiclepark == "Plane")
            {
                Plane myPlane = new Plane();
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
