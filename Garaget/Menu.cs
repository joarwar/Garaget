using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget
{
    public abstract class Menu
    {
        public abstract Menu ShowMenu();
        public abstract bool HandleInput();

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
