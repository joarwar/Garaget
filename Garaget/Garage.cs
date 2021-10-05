using System.Collections;
using System.Collections.Generic;

namespace Garaget
{
    //interface IEnumerator<T>
    //{
    //    void ListVehicles(T item);
    //    void AddVehicle(T item);
    //}

    class Garage <T> : IEnumerable<T> where T : Vehicles
    {
        public uint ParkingSpots { get; private set; }
        private List<T> _vehicles = new List<T>();

        public void AddVehicle(T item)
        {
            _vehicles.Add(item);
        }

        public T this[int idx] => _vehicles[idx]; // Indexer - Used for returning a value based on a int index
        public int Count => _vehicles.Count;

        public Garage(uint parkingSpots)
        {
            ParkingSpots = parkingSpots;
        }

        // returning the Enumerator of the List _vehicles.
        // In order to use this,
        /*
         * Instantiate IEnumerator<Vehicles> vehi = garaget.GetEnumerator();
         * while()
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
    }
}
