using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget
{
    class Garage
    {
        public int ParkingSpots { get; set; }
        public Garage(int parkingSpots)
        {
            ParkingSpots = parkingSpots;
        }
    }
}
