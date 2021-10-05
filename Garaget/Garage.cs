using System.Collections;
using System.Collections.Generic;
using System;

namespace Garaget
{

    class Garage <T> : IEnumerable<T> where T : Vehicles
    {
        public uint ParkingSpots { get; private set; }
        private List<T> _vehicles = new List<T>();

        public T this[int idx] => _vehicles[idx]; // Indexer - Used for returning a value based on a int index
        public int Count => _vehicles.Count;

        public Garage(uint parkingSpots)
        {
            ParkingSpots = parkingSpots;
        }

        public bool AddVehicle(T item)
        {
            if(_vehicles.Count == ParkingSpots)
            {
                Console.WriteLine("Garage is full, vehicle not parked");
                return false;
            }
            _vehicles.Add(item);
            return true;
        }

        public void RemoveVehicle(T item)
        {
            _vehicles.Remove(item);
        }

        public bool SearchVehicle(string regNr)
        {
            foreach(T item in _vehicles)
            {
                if(item.Number == regNr)
                {
                    return true;
                }
            }
            return false;
        }

        public void ListVehicles()
        {
            foreach(T vehicle in _vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }

        public void ListTypesOfVehicles()
        {
            List<string> types = new List<string>();
            foreach(T vehicle in _vehicles)
            {
                string vehicleType = vehicle.GetType().Name;
                if(types.Contains(vehicleType))
                {
                    continue;
                }
                types.Add(vehicleType);
            }
            foreach(string type in types)
            {
                Console.WriteLine(type);
            }
        }
        

        

        #region IEnumerableImplementation
        /*
         returning the Enumerator of the List _vehicles.
         In order to use this,
        
         Instantiate IEnumerator<Vehicles> vehi = garaget.GetEnumerator();
         while()
        */
        public IEnumerator<T> GetEnumerator()
        {
            return _vehicles.GetEnumerator();
        }

        // Legacy implementation
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Legacy implementation
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}
