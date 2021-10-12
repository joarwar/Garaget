using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget
{
    class Bus : Vehicle
    {
        public bool IsSchoolBus { get; set; }
        public uint Floor { get; set; }
        public Bus(uint tires, string registerNumber, string color, uint space, string brand, bool isSchoolBus, uint floor) : base(tires, registerNumber, color, space, brand)
        {
            IsSchoolBus = isSchoolBus;
            Floor = floor;
            ObjType = 2;
        }
        public override string ToString()
        {
            return base.ToString() + 
                "\n" +  (IsSchoolBus ? "Is School bus":"Is not a school bus") + 
                "\nFloors: " + Floor; 
        }
    }
}
