using Garaget.FileManagement;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Garaget
{
    [JsonObject]
    class Garage <T> : IEnumerable<T> where T : Vehicle
    {
        public uint ParkingSpots { get; private set; }
        public List<T> vehicles;

        public T this[int idx] => vehicles[idx];
        public int Count => vehicles.Count;

        public Garage(uint parkingSpots)
        {
            ParkingSpots = parkingSpots;
            vehicles = new List<T>();
        }

        public bool AddVehicle(T item)
        {
            if(vehicles.Count == ParkingSpots)
            {
                Console.WriteLine("Garage is full, vehicle not parked");
                return false;
            }
            vehicles.Add(item);
            return true;
        }

        public void RemoveVehicle(T item)
        {
            vehicles.Remove(item);
        }

        public bool SearchVehicle(string regNr)
        {
            foreach(T item in vehicles)
            {
                if(item.RegisterNumber == regNr)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Search the garage for all vehicles with a matching property and value pair. Input "value" must be of same type
        /// as the property looked for
        /// </summary>
        /// <typeparam name="TType"></typeparam>
        /// <param name="property"></param>
        /// <param name="searchInput"></param>
        /// <returns>A list of vehicles</returns>
        public List<T> SearchVehicles<TType>(string property, TType searchInput)
        {
            List<T> returnList = new List<T>();
            foreach(T item in vehicles)
            {
                if(!item.HasProperty(property))
                {
                    continue;
                }
                TType propertyValue = item.GetPropValue<TType>(property);

                bool isCaseInsesitiveMatch = false;
                if(propertyValue.GetType().Name == "String")
                {
                    if(propertyValue.ToString().ToLower() == searchInput.ToString().ToLower())
                    {
                        isCaseInsesitiveMatch = true;
                    }
                }

                if(isCaseInsesitiveMatch || propertyValue.Equals(searchInput)) 
                {
                    returnList.Add(item);
                }
            }
            return returnList;
        }

        public List<T> ListVehicles()
        {
            return vehicles;
        }

        public List<string> ListTypesOfVehicles()
        {
            List<string> types = new List<string>();
            foreach(T vehicle in vehicles)
            {
                string vehicleType = vehicle.GetType().Name;
                if(types.Contains(vehicleType))
                {
                    continue;
                }
                types.Add(vehicleType);
            }
            return types;
            //foreach(string type in types)
            //{
            //    Console.WriteLine(type);
            //}
        }
        
        public void SaveState(string path)
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            using(StreamWriter file = new StreamWriter(path, false, Encoding.GetEncoding("ISO-8859-1")))
            {
                file.Write(json);
            }
        }

        public static bool RestoreState(string path)
        {
            if(!File.Exists(path))
            {
                return false;
            }
            using(StreamReader file = new StreamReader(path, Encoding.GetEncoding("ISO-8859-1")))
            {
                JsonConverter converter = new BaseConverter();
                Program.garage = JsonConvert.DeserializeObject<Garage<Vehicle>>(file.ReadToEnd(), converter);
            }
            return true;
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
            return vehicles.GetEnumerator();
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
