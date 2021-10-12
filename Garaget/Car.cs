using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget
{
    class Car : Vehicle
    {
        public string Fuel { get; set; }
        public bool IsCabriolet { get; set; }
        public Car(uint tires, string registerNumber, string color, uint space, string brand, string fuel, bool isCabriolet) : base(tires, registerNumber, color, space, brand)
        {
            Fuel = fuel;
            IsCabriolet = isCabriolet;
            ObjType = 1;
        }
        public override string ToString()
        {
            return base.ToString() +
                "\nFuel: " + Fuel +
                "\n" + (IsCabriolet ? "Is cabriolet" : "Is not a cabriolet");
        }

    }
}
