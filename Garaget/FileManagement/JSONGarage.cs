using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Garaget;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Garaget.FileManagement
{
    class JSONGarage
    {
        public static void SaveState(string path)
        {
            JObject writeObject = JObject.FromObject(Program.garage);
            using(StreamWriter file = new StreamWriter(path, false, Encoding.GetEncoding("ISO-8859-1")))
            using(JsonTextWriter writer = new JsonTextWriter(file))
            {
                writer.Formatting = Formatting.Indented;
                writeObject.WriteTo(writer);
            }
        }

        public static void RestoreState(string path)
        {
            using(StreamReader file = new StreamReader(path, Encoding.GetEncoding("ISO-8859-1")))
            {
                var deserializedObject = JsonConvert.DeserializeObject<Garage<Vehicles>>(file.ReadToEnd());
                Program.garage = deserializedObject;
            }
        }

    }

}
