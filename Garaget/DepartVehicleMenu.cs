using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget
{
    class DepartVehicleMenu : Menu
    {
        public override bool HandleInput()
        {
            throw new NotImplementedException();
        }

        public override Menu ShowMenu()
        {
            Console.WriteLine("What car would you like to take out?");          
            
            List<Vehicles> Vehiclesmade = new List<Vehicles>(10);
           
            //Vehicles.ForEach(Console.WriteLine);

            Vehiclesmade.RemoveAt(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Drive safely!");
            return null;
        }
    }
}
