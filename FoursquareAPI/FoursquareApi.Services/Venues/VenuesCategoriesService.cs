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
    public class VenuesCategoriesService
    {
        private const string ServerUrl = "https://api.foursquare.com/v2/venues/categories";
        private readonly IHttpClient _httpClient;
        private readonly string _clientId;
        private readonly string _clientSecret;

        public VenuesCategoriesService(string clientId, string clientSecret)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            ISerializationService serializationService = new SerializationService();
            _httpClient = new HttpClient.HttpClient(serializationService);
        }
        public VenuesCategoriesModel VenuesCategories()
        {
            var argsDict = VenuesArgsDictionaryService.VenuesCategoriesDictionary(_clientId, _clientSecret);
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(ServerUrl, queryString);
            var venuesCategoriesModel = _httpClient.SendGetRequest<VenuesCategoriesModel>(requestUrl).Result;
            return venuesCategoriesModel;
        }
    }
}
