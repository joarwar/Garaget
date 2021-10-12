using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Garaget.FileManagement
{
    public class BaseConverter : JsonConverter
    {
        static JsonSerializerSettings SpecifiedSubclassConversion =
            new JsonSerializerSettings() { ContractResolver = new BaseSpecifiedConcreteClassConverter() };

        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Vehicle));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);
            switch(jo["ObjType"].Value<int>())
            {
                case 1:
                    return JsonConvert.DeserializeObject<Car>(jo.ToString(), SpecifiedSubclassConversion);
                case 2:
                    return JsonConvert.DeserializeObject<Bus>(jo.ToString(), SpecifiedSubclassConversion);
                case 3:
                    return JsonConvert.DeserializeObject<Motorcycle>(jo.ToString(), SpecifiedSubclassConversion);
                case 4:
                    return JsonConvert.DeserializeObject<Plane>(jo.ToString(), SpecifiedSubclassConversion);
                case 5:
                    return JsonConvert.DeserializeObject<Truck>(jo.ToString(), SpecifiedSubclassConversion);
                default:
                    throw new Exception();
            }
            throw new NotImplementedException();
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException(); // won't be called because CanWrite returns false
        }
    }
}
