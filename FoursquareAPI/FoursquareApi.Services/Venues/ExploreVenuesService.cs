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
    public class ExploreVenuesService
    {
        private const string ServerUrl = "https://api.foursquare.com/v2/venues/explore";
        private readonly IHttpClient _httpClient;
        private readonly string _clientId;
        private readonly string _clientSecret;

        public ExploreVenuesService(string clientId, string clientSecret)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            ISerializationService serializationService = new SerializationService();
            _httpClient = new HttpClient.HttpClient(serializationService);
        }

        public ExploreVenuesModel ExploreVenues(double latitude, double longitude, double? lAcc = null, double? alt = null, double? altAcc = null, double? radius = null, string section = null,
                                                string query = null,int? limit = null, int? offset = null,string novelty = null, string friendVisits = null,string time = null,string day = null, 
                                                bool? venuePhotos = null,string lastVenue = null,bool? openNow = null,bool? sortByDistance = null,int[]price = null,bool? saved = null,
                                                bool? specials = null)
        {
            var argsDict = VenuesArgsDictionaryService.ExploreVenuesDictionary(_clientId,_clientSecret,latitude,longitude,lAcc,alt,altAcc,radius,section,query,limit,offset,novelty,
                                                                                    friendVisits,time,day,venuePhotos,lastVenue,openNow,sortByDistance,price,saved,specials);
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(ServerUrl, queryString);
            var exploreVenuesModel = _httpClient.SendGetRequest<ExploreVenuesModel>(requestUrl).Result;
            return exploreVenuesModel;
        }

        public ExploreVenuesModel ExploreVenues(string near, double? lAcc = null, double? alt = null, double? altAcc = null, double? radius = null, string section = null,
                                                string query = null, int? limit = null, int? offset = null, string novelty = null, string friendVisits = null, string time = null, string day = null,
                                                bool? venuePhotos = null, string lastVenue = null, bool? openNow = null, bool? sortByDistance = null, int[] price = null, bool? saved = null,
                                                bool? specials = null)
        {
            var argsDict = VenuesArgsDictionaryService.ExploreVenuesDictionary(_clientId, _clientSecret, near, lAcc, alt, altAcc, radius, section, query, limit, offset, novelty,
                                                                                    friendVisits, time, day, venuePhotos, lastVenue, openNow, sortByDistance, price, saved, specials);
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(ServerUrl, queryString);
            var exploreVenuesModel = _httpClient.SendGetRequest<ExploreVenuesModel>(requestUrl).Result;
            return exploreVenuesModel;
        }
    }
}
