using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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

        public int ObjType { get; set; }

        public Vehicle(uint tires, string registerNumber, string color, uint space, string brand )
        {
            Tires = tires;
            RegisterNumber = registerNumber;
            Color = color;
            Space = space;
            Brand = brand;
        }

        public override string ToString()
        {
            return "Registration number: " + RegisterNumber +
                "\nColor: " + Color +
                "\nBrand: " + Brand +
                "\nTires: " + Tires +
                "\nNumber of seats: " + Space; 
            
        }




    }
}
