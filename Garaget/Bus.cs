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
        public int Floor { get; set; }
        public Bus(uint tires, string registerNumber, string color, uint space, string brand, bool isSchoolBus, int floor) : base(tires, registerNumber, color, space, brand)
        {
            IsSchoolBus = isSchoolBus;
            Floor = floor;
        }
    }
}
