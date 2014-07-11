using FoursquareApi.Models.Venues;
using HttpClient;
using HttpClient.SerializationService;

namespace FoursquareApi.Services.Venues
{
    public class SearchVenuesService
    {
        private const string ServerUrl = "https://api.foursquare.com/v2/venues/search";
        private readonly IHttpClient _httpClient;
        private readonly string _clientId;
        private readonly string _clientSecret;

        public SearchVenuesService(string clientId, string clientSecret)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            ISerializationService serializationService = new SerializationService();
            _httpClient = new HttpClient.HttpClient(serializationService);
        }

        public SearchVenuesModel SearchVenues(double latitude, double longitude, string query = null, int? limit = null, string intent="checkin", double? radius = null,string categoryId = null,string url = null, string providerId = null,string linkedId = null)
        {
            var argsDict = VenuesArgsDictionaryService.SearchVenuesDictionary(_clientId,_clientSecret,latitude, longitude, query, limit,intent,radius,categoryId,url,providerId,linkedId);
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(ServerUrl, queryString);
            var searchVenuesModel = _httpClient.SendGetRequest<SearchVenuesModel>(requestUrl).Result;
            return searchVenuesModel;
        }

        public SearchVenuesModel SearchVenues(string near, string query = null, int? limit = null, string intent = "checkin", double? radius = null, string sw = null, string ne = null, string categoryId = null, string url = null, string providerId = null, string linkedId = null)
        {
            var argsDict = VenuesArgsDictionaryService.SearchVenuesDictionary(_clientId, _clientSecret,near, query, limit, intent, radius, sw, ne, categoryId, url, providerId, linkedId);
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(ServerUrl, queryString);
            var searchVenuesModel = _httpClient.SendGetRequest<SearchVenuesModel>(requestUrl).Result;
            return searchVenuesModel;
        }
       
        
    }
}
