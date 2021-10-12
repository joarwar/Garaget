﻿using System.Collections;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace Garaget
{
    [JsonObject]
    class Garage <T> : IEnumerable<T> where T : Vehicle
    {
        public uint ParkingSpots { get; private set; }
        public List<T> _vehicles;

        public T this[int idx] => _vehicles[idx]; // Indexer - Used for returning a value based on a int index
        public int Count => _vehicles.Count;

        public Garage(uint parkingSpots)
        {
            ParkingSpots = parkingSpots;
            _vehicles = new List<T>();
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
                if(item.RegisterNumber == regNr)
                {
                    return true;
                }
            }
            return false;
        }

        // For the SearchVehicles I've included an extensionclass (found in ObjectExtension.cs)
        // The method takes a property as a string (this is case sensitive)
        // and matches against a property in the class. And then returns the value.

        // in here we declare a list and first find all the objects in the list that has the property at all
        // then we go through them and check the value
        /// <summary>
        /// Search the garage for all vehicles with a matching property and value pair. Input "value" must be of same type
        /// as the property looked for
        /// </summary>
        /// <typeparam name="TType"></typeparam>
        /// <param name="property"></param>
        /// <param name="value"></param>
        /// <returns>A list of vehicles</returns>
        public List<T> SearchVehicles<TType>(string property, TType value)
        {
            List<T> returnList = new List<T>(); // create list to be sent from method
            foreach(T item in _vehicles) // go through all entries in the list
            {
                if(!item.HasProperty(property)) // check if the entry has the property we are looking for
                {
                    continue; // if it does not, we continue to the next entry
                }
                // if it has the property we continue
                TType val = item.GetPropValue<TType>(property); // we store the value of the property of

                // checks case insesitive match
                bool isCaseInsesitiveMatch = false;
                if(val.GetType().Name == "String")
                {
                    string lowerVal = val.ToString().ToLower();
                    string lowerValue = value.ToString().ToLower();
                    if(lowerVal == lowerValue)
                    {
                        isCaseInsesitiveMatch = true;
                    }
                }

                // and check if it is the same value as what was passed in
                if(isCaseInsesitiveMatch || val.Equals(value)) 
                {
                    returnList.Add(item); // if it is, we store it in the list
                }
            }
            return returnList; // and we return the list
        }

        public List<T> ListVehicles()
        {
            return _vehicles;
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
        
        public void SaveState()
        {
            string path = "test.json";
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            using(StreamWriter file = new StreamWriter(path, false, Encoding.GetEncoding("ISO-8859-1")))
            {
                file.Write(json);
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
