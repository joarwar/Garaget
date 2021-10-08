using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Garaget.FileManagement
{
    class JSONWrapper
    {

        public void SaveState(string path)
        {
            JObject writeObject = JObject.FromObject(Program.garage);
            using(StreamWriter file = new StreamWriter(path, false, Encoding.GetEncoding("ISO-8859-1")))
            using(JsonTextWriter writer = new JsonTextWriter(file))
            {
                writer.Formatting = Formatting.Indented;
                writeObject.WriteTo(writer);
            }
        }

        public void RestoreState(string path)
        {
            using(StreamReader file = new StreamReader(path, Encoding.GetEncoding("ISO-8859-1")))
            {
                var deserializedObject = JsonConvert.DeserializeObject<Garage<Vehicles>>(file.ReadToEnd());
                Program.garage = deserializedObject;
            }
        }

        public JArray GetJObjects<T>(List<T> objects)
        {
            JArray jArray = new JArray();
            foreach(T obj in objects)
            {
                jArray.Add(JObject.FromObject(obj));
            }
            return jArray;
        }

        public bool WriteListToFile<T>(List<T> objects, string path)
        {
            if(objects.Count == 0)
            {
                return false;
            }
            if(path == null || path.Length == 0)
            {
                return false;
            }
            JArray writeObject = GetJObjects(objects);
            using(StreamWriter file = File.CreateText(path))
            using(JsonTextWriter writer = new JsonTextWriter(file))
            {
                writer.Formatting = Formatting.Indented;
                writeObject.WriteTo(writer);
            }
            return true;
        }

        public List<T> GetObjectsFromFile<T>(string path)
        {
            List<T> returnList = new List<T>();
            using(StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                returnList = (List<T>)serializer.Deserialize(file, typeof(List<T>));
            }

            return returnList;
        }
    }
}
