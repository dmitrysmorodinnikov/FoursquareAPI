using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Venues;
using HttpClient;
using HttpClient.SerializationService;

namespace FoursquareApi.Services.Venues
{
    public class TrendingVenuesService
    {
        private const string ServerUrl = "https://api.foursquare.com/v2/venues/trending";
        private readonly IHttpClient _httpClient;
        private readonly string _clientId;
        private readonly string _clientSecret;

        public TrendingVenuesService(string clientId, string clientSecret)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            ISerializationService serializationService = new SerializationService();
            _httpClient = new HttpClient.HttpClient(serializationService);
        }

        public TrendingVenuesModel TrendingVenues(double latitude, double longitude, short? limit, short? radius)
        {
            var argsDict = VenuesArgsDictionaryService.TrendingVenuesDictionary(_clientId,_clientSecret,latitude,longitude,limit,radius);
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(ServerUrl, queryString);
            var trendingVenuesModel = _httpClient.SendGetRequest<TrendingVenuesModel>(requestUrl).Result;
            return trendingVenuesModel;
        }
    }
}
