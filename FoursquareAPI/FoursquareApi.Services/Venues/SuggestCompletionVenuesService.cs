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
    public class SuggestCompletionVenuesService
    {
        private const string ServerUrl = "https://api.foursquare.com/v2/venues/suggestcompletion";
        private readonly IHttpClient _httpClient;
        private readonly string _clientId;
        private readonly string _clientSecret;

        public SuggestCompletionVenuesService(string clientId, string clientSecret)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            ISerializationService serializationService = new SerializationService();
            _httpClient = new HttpClient.HttpClient(serializationService);
        }

        public SuggestCompletionVenuesModel SuggestCompletionVenues(double latitude, double longitude, string query, double? lAcc, double? alt , double? altAcc, int? limit,int? radius )
        {
            var argsDict = VenuesArgsDictionaryService.SuggestCompletionDictionary(_clientId, _clientSecret, latitude, longitude,query,lAcc,alt,altAcc,limit,radius);
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(ServerUrl, queryString);
            var suggestComletionVenuesModel = _httpClient.SendGetRequest<SuggestCompletionVenuesModel>(requestUrl).Result;
            return suggestComletionVenuesModel;
        }

        public SuggestCompletionVenuesModel SuggestCompletionVenues(string near, string query, double? lAcc, double? alt, double? altAcc, int? limit, int? radius,string sw, string ne)
        {
            var argsDict = VenuesArgsDictionaryService.SuggestCompletionDictionary(_clientId, _clientSecret, near, query, lAcc, alt, altAcc, limit, radius, ne, sw);
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(ServerUrl, queryString);
            var suggestComletionVenuesModel = _httpClient.SendGetRequest<SuggestCompletionVenuesModel>(requestUrl).Result;
            return suggestComletionVenuesModel;
        }
    }
}
