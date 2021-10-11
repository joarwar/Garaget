using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget
{
    class SearchVehiclesMenu : Menu
    {
        public override bool HandleInput()
        {
            List<Vehicle> searchVehicleList = new List<Vehicle>();
            int searchMenu = ParseInput(Console.ReadLine(), 15);
            switch (searchMenu)
            {
                case 1:
                    Console.WriteLine("What color?");
                    searchVehicleList = Program.garage.SearchVehicles("Color", Console.ReadLine()); 
                    break;
                case 2:
                    Console.WriteLine("What registration number?");
                    searchVehicleList = Program.garage.SearchVehicles("RegisterNumber", Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("What brand?");
                    searchVehicleList = Program.garage.SearchVehicles("Brand", Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("How many fit in the vehicle?");
                    searchVehicleList = Program.garage.SearchVehicles("Space", GetPositiveIntFromUser());
                    break;
                case 5:
                    Console.WriteLine("How many tires does the vehicle have?");
                    searchVehicleList = Program.garage.SearchVehicles("Tires", GetPositiveIntFromUser());
                    break;
                case 6:
                    Console.WriteLine("What fuel does your vehicle use?");
                    searchVehicleList = Program.garage.SearchVehicles("Fuel",Console.ReadLine());
                    break;
                case 7:
                    Console.WriteLine("Is your vehicle a cabriolet?");
                    searchVehicleList = Program.garage.SearchVehicles("IsCabriolet", GetBoolFromUser()); 
                    break;
                case 8:
                    Console.WriteLine("Is it a school bus?");
                    searchVehicleList = Program.garage.SearchVehicles("IsSchoolBus", GetBoolFromUser());
                    break;
                case 9:
                    Console.WriteLine("How many floor does the vehicle have?");
                    searchVehicleList = Program.garage.SearchVehicles("Floor", GetPositiveIntFromUser());
                    break;
                case 10:
                    Console.WriteLine("What's the price of the vehicle?");
                    searchVehicleList = Program.garage.SearchVehicles("Price", GetDecimalFromUser());
                    break;
                case 11:
                    Console.WriteLine("How many cylinders does the vehicle have?");
                    searchVehicleList = Program.garage.SearchVehicles("Cylinder", GetPositiveIntFromUser());
                    break;
                case 12:
                    Console.WriteLine("How many wings does the vehicle have?");
                    searchVehicleList = Program.garage.SearchVehicles("Wings", GetPositiveIntFromUser());
                    break;
                case 13:
                    Console.WriteLine("Is it a private plane?");
                    searchVehicleList = Program.garage.SearchVehicles("IsPrivate", GetBoolFromUser());
                    break;
                case 14:
                    Console.WriteLine("Is it a pickup?");
                    searchVehicleList = Program.garage.SearchVehicles("IsPickup", GetBoolFromUser());
                    break;
                case 15:
                    Console.WriteLine("What is the model year of the vehicle?");
                    searchVehicleList = Program.garage.SearchVehicles("ModelYear", GetIntFromUser());
                    break;
                default:
                    Console.WriteLine("Try again, please type a number between 1-12");
                    cont = false;
                    break;
            }
            foreach (Vehicle vehicle in searchVehicleList)
            {
                Console.WriteLine(vehicle);
                Console.WriteLine("----------------------------------");
            }
            return null;
        }


        public override Menu ShowMenu()
        {
            return null;
        }

        private bool GetBoolFromUser()
        {
            bool returnValue;
            while (!bool.TryParse(Console.ReadLine(), out returnValue))
            {
                Console.WriteLine("Please only write True or False");
            }
            return returnValue;
        }
        private uint GetPositiveIntFromUser()
        {
            uint posInt;
            while (!uint.TryParse(Console.ReadLine(), out posInt))
            {
                Console.WriteLine("Please only write whole numbers");
            }
            return posInt;
        }
        private decimal GetDecimalFromUser()
        {
            decimal decNumber;
            while (!decimal.TryParse(Console.ReadLine(), out decNumber)) 
            {
                Console.WriteLine("Please only write numbers");
            }
            return decNumber;
        }
        private int GetIntFromUser()
        {
            int normInt;
            while (!int.TryParse(Console.ReadLine(), out normInt))
            {
                Console.WriteLine("Please only write whole numbers");
            }
            return normInt;
        }
    }
}
