using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget
{
    public abstract class Menu
    {
        public void ShowMenu()
        {

        }

        public bool HandleInput()
        {
            
        }

        /// <summary>
        /// Returns the integer based on amountOfMenuOptions. Assumes a 0-based menu system.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="amountOfMenuOptions"></param>
        /// <returns>If not an integer, return -1, if integer higher than maxValue return int.MaxValue</returns>
        public int ParseInput(string value, int amountOfMenuOptions)
        {
            int returnValue;
            if(!int.TryParse(value, out returnValue))
            {
                return -1;
            }
            if(returnValue > amountOfMenuOptions)
            {
                return int.MaxValue;
            }
            return returnValue;
        }
        // Show
        // Input
        // Parse

        //public void ShowMainMenu()
        //{
        //    Console.WriteLine("What do you want to do?"
        //                        + "\n1. Park vehicle." // also creates vehicle
        //                        + "\n2. List vehicles." // show created vehicles
        //                        + "\n3. Search vehicles." // searches all vehicles through properties
        //                        + "\n4. Depart vehicle from garage." // removes vehicle from garage
        //                        + "\n0. Exit application."); 
        //    // Handle input
        //}

        //public void ShowParkVehicle()
        //{
        //    Console.WriteLine("What vehicle would you like to park?"
        //                  + "\n1. Motorcycle"            
        //                  + "\n2. Car"
        //                  + "\n3. Bus"
        //                  + "\n4. Truck"
        //                  + "\n5. Plane"
        //                  + "\n0. Back to Main menu");
        //    // Handle input
        //}

        //public void ListVehicles()
        //{
        //    Console.WriteLine("Listing all vehicles...");
        //    // Functionality to list all vehicles
        //}
        //public void ShowSearchVehicles()
        //{
        //    Console.WriteLine("Find a vehicle in the garage by adding a parameter."
        //                  + "\n1. To find with a registration number."
        //                  + "\n2. To find all with colour."
        //                  + "\n3. To find all with a specified number of wheels."
        //                  + "\n4. To find all with a minimum number of passengers."
        //                  + "\n5. To find all with cabriolet"
        //                  + "\n0. Exit the finding!");
        //}

        //public void ShowDepartVehicleMenu()
        //{

        //}

        //public void ShowFindByRegNumber()
        //{
        //    Console.WriteLine("Find by reg");      
        //}

        //public void ShowFindByColor()
        //{
        //    Console.WriteLine("");
        //}

        //public void ShowByAmountOfWheels()
        //{
        //    Console.WriteLine("");
        //}

        //public void ShowVehicleByMinimumPassengers()
        //{
        //    Console.WriteLine("");
        //}

        //public void ShowCabriolet()
        //{
        //    Console.WriteLine("");
        //}

        //public void ShowExit()
        //{
        //    Console.WriteLine("");
        //}
    }
}
