using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClient.SerializationService
{
    public interface ISerializationService
    {
        string Serialize(object obj);
        TResult Deserialize<TResult>(string serializedObject);
    }
}
