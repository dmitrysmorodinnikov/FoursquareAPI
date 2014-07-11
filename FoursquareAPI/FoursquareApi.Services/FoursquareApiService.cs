using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpClient;
using HttpClient.SerializationService;

namespace FoursquareApi.Services
{
    public abstract class FoursquareApiService
    {
        protected string _clientId;
        protected string _clientSecret;
        protected string _redirectUri;
        protected string _accessToken;
        protected IHttpClient _httpClient;

        protected void Initialize(string clientId, string clientSecret, string accessToken)
        {
            _accessToken = accessToken;
            _clientId = clientId;
            _clientSecret = clientSecret;
            ISerializationService serializationService = new SerializationService();
            _httpClient = new HttpClient.HttpClient(serializationService);
        }

        protected void Initialize(string accessToken)
        {
            _accessToken = accessToken;
            ISerializationService serializationService = new SerializationService();
            _httpClient = new HttpClient.HttpClient(serializationService);
        }
    }
}
