using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget
{
    class Plane : Vehicle 
    {

        public uint Wings { get; set; }
        public bool IsPrivate { get; set; }
        public Plane(uint tires, string registerNumber, string color, uint space, string brand, uint wings, bool isPrivate) : base(tires,registerNumber,color,space,brand)
        {
            Wings = wings;
            IsPrivate = isPrivate;
        } 
    }
}
