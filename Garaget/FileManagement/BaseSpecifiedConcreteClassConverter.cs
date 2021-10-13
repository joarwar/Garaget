using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

// Implementation based on the following thread
// https://stackoverflow.com/questions/20995865/deserializing-json-to-abstract-class
namespace Garaget.FileManagement
{
    public class BaseSpecifiedConcreteClassConverter : DefaultContractResolver
    {
        protected override JsonConverter ResolveContractConverter(Type objectType)
        {
            if(typeof(Vehicle).IsAssignableFrom(objectType) && !objectType.IsAbstract)
                return null; // pretend TableSortRuleConvert is not specified (thus avoiding a stack overflow)
            return base.ResolveContractConverter(objectType);
        }
    }
}
