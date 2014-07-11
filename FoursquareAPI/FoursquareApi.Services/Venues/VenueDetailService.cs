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
    public class VenueDetailService
    {
        private string _serverUrl;// = "https://api.foursquare.com/v2/venues/";
        private IHttpClient _httpClient;
        private string _clientId;
        private string _clientSecret;
        private readonly ISerializationService _serializationService;
        private readonly string _venueId;

        public VenueDetailService(string clientId, string clientSecret, string venueId)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            _venueId = venueId;
            _serializationService = new SerializationService();
            _httpClient = new HttpClient.HttpClient(_serializationService);
            _serverUrl = string.Format("{0}/{1}", "https://api.foursquare.com/v2/venues", _venueId);
        }
        public VenueDetailModel VenueDetail()
        {
            var argsDict = VenuesArgsDictionaryService.VenueDetailDictionary(_clientId, _clientSecret);
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(_serverUrl, queryString);
            var venueDetailModel = _httpClient.SendGetRequest<VenueDetailModel>(requestUrl).Result;
            return venueDetailModel;
        }
    }
}
