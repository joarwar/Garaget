using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget
{
    public abstract class Vehicle
    {
        public uint Tires { get; set; }

        public string RegisterNumber { get; set; }

        public string Color { get; set; }

        public uint Space { get; set; }

        public string Brand { get; set; }

        public Vehicle(uint tires, string registerNumber, string color, uint space, string brand )
        {
            Tires = tires;
            RegisterNumber = registerNumber;
            Color = color;
            Space = space;
            Brand = brand;
        }





    }
}
