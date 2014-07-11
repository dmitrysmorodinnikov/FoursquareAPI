using System;
using Newtonsoft.Json;

namespace HttpClient.SerializationService
{
    public class SerializationService : ISerializationService
    {
        public string Serialize(object obj)
        {
            if(obj == null)
                throw new ArgumentNullException();
            return JsonConvert.SerializeObject(obj);
        }

        public TResult Deserialize<TResult>(string serializedObject)
        {
            if (string.IsNullOrWhiteSpace(serializedObject))
                return default(TResult);
            return JsonConvert.DeserializeObject<TResult>(serializedObject);
        }
    }
}
