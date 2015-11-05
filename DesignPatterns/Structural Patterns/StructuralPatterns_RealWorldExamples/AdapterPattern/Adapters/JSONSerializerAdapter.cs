//Refernece: System.Web.Extensions
using System.Web.Script.Serialization;
using AdapterPattern.Target;

namespace AdapterPattern.Adapters
{
    public class JSONSerializerAdapter:ISerializerAdapter
    {
        public string Serialize<T>(object objToSerialize)
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Serialize(objToSerialize);
        }
    }
}
