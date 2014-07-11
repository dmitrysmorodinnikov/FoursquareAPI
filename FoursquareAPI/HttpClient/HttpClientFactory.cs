using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpClient.SerializationService;

namespace HttpClient
{
    public static class HttpClientFactory
    {
        public static HttpClient CreateHttpClient()
        {
            ISerializationService serializationService = new SerializationService.SerializationService();
            return new HttpClient(serializationService);
        }
    }
}
