using FoursquareApi.Models;
using FoursquareApi.Models.Venues;
using FoursquareApi.Services.Venues;

namespace FoursquareApi.Services
{
    public class VenuesService : FoursquareApiService
    {
        public VenuesService(string clientId, string clientSecret, string accessToken)
        {
            Initialize(clientId,clientSecret, accessToken);
        }

        //Get,checked
        public FoursquareBaseModel<SearchVenuesResponse> SearchVenues(double latitude, double longitude, string query = null, int? limit = null, string intent = "checkin", double? radius = null, string categoryId = null, string url = null, string providerId = null, string linkedId = null)
        {
            const string serverUrl = "https://api.foursquare.com/v2/venues/search";
            var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).SearchVenuesDictionary(latitude, longitude, query, limit, intent, radius, categoryId, url, providerId, linkedId);
            return ResultService.GetResult<FoursquareBaseModel<SearchVenuesResponse>>(serverUrl, argsDict, _httpClient);
        }

        //Get,checked
        public FoursquareBaseModel<SearchVenuesResponse> SearchVenues(string near, string query = null, int? limit = null, string intent = "checkin", double? radius = null, string sw = null, string ne = null, string categoryId = null, string url = null, string providerId = null, string linkedId = null)
        {
            const string serverUrl = "https://api.foursquare.com/v2/venues/search";
            var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).SearchVenuesDictionary(near, query, limit, intent, radius, sw, ne, categoryId, url, providerId, linkedId);
            return ResultService.GetResult<FoursquareBaseModel<SearchVenuesResponse>>(serverUrl, argsDict, _httpClient);
        }

        //Get,checked
        public VenueDetailModel VenueDetail(string venueId)
        {
            string serverUrl = string.Format("{0}/{1}", "https://api.foursquare.com/v2/venues", venueId);
            var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).VenueDetailDictionary();
            return ResultService.GetResult<VenueDetailModel>(serverUrl, argsDict, _httpClient);
        }

        //Get,checked
        public TrendingVenuesModel TrendingVenues(double latitude, double longitude, short? limit = null, short? radius = null)
        {
            const string serverUrl = "https://api.foursquare.com/v2/venues/trending";
            var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).TrendingVenuesDictionary(latitude, longitude, limit, radius);
            return ResultService.GetResult<TrendingVenuesModel>(serverUrl, argsDict, _httpClient);
        }

        //Get,checked
        public VenuesCategoriesModel VenuesCategories()
        {
            const string serverUrl = "https://api.foursquare.com/v2/venues/categories";
            var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).VenuesCategoriesDictionary();
            return ResultService.GetResult<VenuesCategoriesModel>(serverUrl, argsDict, _httpClient);
        }

        //Get,checked
        public ExploreVenuesModel ExploreVenues(double latitude, double longitude, double? lAcc = null, double? alt = null, double? altAcc = null, double? radius = null, string section = null,
                                                string query = null, int? limit = null, int? offset = null, string novelty = null, string friendVisits = null, string time = null, string day = null,
                                                bool? venuePhotos = null, string lastVenue = null, bool? openNow = null, bool? sortByDistance = null, int[] price = null, bool? saved = null,
                                                bool? specials = null)
        {
            const string serverUrl = "https://api.foursquare.com/v2/venues/explore";
            var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).ExploreVenuesDictionary(latitude, longitude, lAcc, alt, altAcc, radius, section, query, limit, offset, novelty,
                                                                                   friendVisits, time, day, venuePhotos, lastVenue, openNow, sortByDistance, price, saved, specials);
            return ResultService.GetResult<ExploreVenuesModel>(serverUrl, argsDict, _httpClient);
        }

        //Get,checked
        public ExploreVenuesModel ExploreVenues(string near, double? lAcc = null, double? alt = null, double? altAcc = null, double? radius = null, string section = null,
                                                string query = null, int? limit = null, int? offset = null, string novelty = null, string friendVisits = null, string time = null, string day = null,
                                                bool? venuePhotos = null, string lastVenue = null, bool? openNow = null, bool? sortByDistance = null, int[] price = null, bool? saved = null,
                                                bool? specials = null)
        {
            const string serverUrl = "https://api.foursquare.com/v2/venues/explore";
            var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).ExploreVenuesDictionary(near, lAcc, alt, altAcc, radius, section, query, limit, offset, novelty,
                                                                                    friendVisits, time, day, venuePhotos, lastVenue, openNow, sortByDistance, price, saved, specials);
            return ResultService.GetResult<ExploreVenuesModel>(serverUrl, argsDict, _httpClient);
        }

        //Get,checked
        public SuggestCompletionVenuesModel SuggestCompletionVenues(double latitude, double longitude, string query, double? lAcc = null, double? alt = null, double? altAcc = null,
                                                                    int? limit = null, int? radius = null)
        {
            const string serverUrl = "https://api.foursquare.com/v2/venues/suggestcompletion";
            var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).SuggestCompletionDictionary(latitude, longitude, query, lAcc, alt, altAcc, limit, radius);
            return ResultService.GetResult<SuggestCompletionVenuesModel>(serverUrl, argsDict, _httpClient);
        }

        //Get,checked
        public SuggestCompletionVenuesModel SuggestCompletionVenues(string near, string query, double? lAcc = null, double? alt = null, double? altAcc = null, int? limit = null, int? radius = null, string sw = null, string ne = null)
        {
            const string serverUrl = "https://api.foursquare.com/v2/venues/suggestcompletion";
            var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).SuggestCompletionDictionary(near, query, lAcc, alt, altAcc, limit, radius, ne, sw);
            return ResultService.GetResult<SuggestCompletionVenuesModel>(serverUrl, argsDict, _httpClient);
        }
        
        //Post
        //public VenueDetailModel AddVenue(string name, double latitude, double longitude, string address = null, string crossStreet = null, string city = null, string state = null,
        //                                string zip = null, string phone = null, string twitter = null, string primaryCategoryId = null, string description = null, string url = null,
        //                                bool? ignoreDuplicates = null, string ignoreDuplicatesKey = null)
        //{
        //    if (!IsAuthenticated())
        //        return null;
        //    const string serverUrl = "https://api.foursquare.com/v2/venues/add";
        //    var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).AddVenueDictionary(name, latitude, longitude, address, crossStreet, city, state,
        //                                zip, phone, twitter, primaryCategoryId, description, url,
        //                                ignoreDuplicates, ignoreDuplicatesKey);
        //    return ResultService.PostResult<VenueDetailModel>(serverUrl, argsDict, _httpClient);
        //}

        ////Get
        //public ManagedVenuesModel ManagedVenues(int? limit = null, int? offset = null)
        //{
        //    if (!IsAuthenticated())
        //        return null;
        //    const string serverUrl = "https://api.foursquare.com/v2/venues/managed";
        //    var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).ManagedVenuesDictionary(limit,offset);
        //    return ResultService.GetResult<ManagedVenuesModel>(serverUrl, argsDict, _httpClient);
        //}

        ////Get
        //public VenueTimeSeriesModel VenueTimeseries(long startAt, long? endAt = null, string venueId = null, string fields = null)
        //{
        //    if (!IsAuthenticated())
        //        return null;
        //    const string serverUrl = "https://api.foursquare.com/v2/venues/timeseries";
        //    var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).TimeseriesVenuesDictionary(startAt,endAt,venueId,fields);
        //    return ResultService.GetResult<VenueTimeSeriesModel>(serverUrl, argsDict, _httpClient);
        //}

        #region Venue Aspects

        //Get,checked
        public VenueEventsModel VenueEvents(string venueId)
        {
            string serverUrl = "https://api.foursquare.com/v2/venues/" + venueId + "/events";
            var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).EmptyVenuesDictionary();
            return ResultService.GetResult<VenueEventsModel>(serverUrl, argsDict, _httpClient);
        }

        //Get,checked
        public HereNowModel HereNow(string venueId, int? limit = null, int? offset = null)
        {
            if (!IsAuthenticated())
                return null;
            string serverUrl = "https://api.foursquare.com/v2/venues/" + venueId + "/herenow";
            var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).HereNowVenuesDictionary(limit,offset);
            return ResultService.GetResult<HereNowModel>(serverUrl, argsDict, _httpClient);
        }

        //Get,checked
        public VenueHoursModel VenueHours(string venueId)
        {
            string serverUrl = "https://api.foursquare.com/v2/venues/" + venueId + "/hours";
            var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).EmptyVenuesDictionary();
            return ResultService.GetResult<VenueHoursModel>(serverUrl, argsDict, _httpClient);
        }

        //Get,checked
        public VenueLikesModel VenueLikes(string venueId)
        {
            string serverUrl = "https://api.foursquare.com/v2/venues/" + venueId + "/likes";
            var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).EmptyVenuesDictionary();
            return ResultService.GetResult<VenueLikesModel>(serverUrl, argsDict, _httpClient);
        }

        //Get,checked
        public VenueLinksModel VenueLinks(string venueId)
        {
            string serverUrl = "https://api.foursquare.com/v2/venues/" + venueId + "/links";
            var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).EmptyVenuesDictionary();
            return ResultService.GetResult<VenueLinksModel>(serverUrl, argsDict, _httpClient);
        }

        //Get,checked
        public VenueListsModel VenueLists(string venueId, string group = null, int? limit = null, int? offset = null)
        {
            string serverUrl = "https://api.foursquare.com/v2/venues/" + venueId + "/listed";
            var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).ListsVenuesDictionary(group,limit,offset);
            return ResultService.GetResult<VenueListsModel>(serverUrl, argsDict, _httpClient);
        }

        //Get,checked
        public VenueMenuModel VenueMenu(string venueId)
        {
            string serverUrl = "https://api.foursquare.com/v2/venues/" + venueId + "/menu";
            var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).EmptyVenuesDictionary();
            return ResultService.GetResult<VenueMenuModel>(serverUrl, argsDict, _httpClient);
        }

        //Get,checked
        public NextVenuesModel NextVenues(string venueId)
        {
            string serverUrl = "https://api.foursquare.com/v2/venues/" + venueId + "/nextvenues";
            var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).EmptyVenuesDictionary();
            return ResultService.GetResult<NextVenuesModel>(serverUrl, argsDict, _httpClient);
        }

        //Get,checked
        public VenuePhotosModel VenuePhotos(string venueId, string group = null, int? limit = null, int? offset = null)
        {
            string serverUrl = "https://api.foursquare.com/v2/venues/" + venueId + "/photos";
            var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).PhotosVenuesDictionary(group,limit,offset);
            return ResultService.GetResult<VenuePhotosModel>(serverUrl, argsDict, _httpClient);
        }

        //Get,checked
        public SimilarVenuesModel SimilarVenues(string venueId)
        {
            string serverUrl = "https://api.foursquare.com/v2/venues/" + venueId + "/similar";
            var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).EmptyVenuesDictionary();
            return ResultService.GetResult<SimilarVenuesModel>(serverUrl, argsDict, _httpClient);
        }

        ////Get
        //public VenueStatsModel VenueStats(string venueId, long? startAt = null, long? endAt = null)
        //{
        //    if (!IsAuthenticated())
        //        return null;
        //    string serverUrl = "https://api.foursquare.com/v2/venues/" + venueId + "/stats";
        //    var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).StatsVenuesDictionary(startAt,endAt);
        //     return ResultService.GetResult<VenueStatsModel>(serverUrl, argsDict, _httpClient);
        //}

        //Get,checked
        public VenueTipsModel VenueTips(string venueId, string sort, int? limit = null, int? offset = null)
        {
            string serverUrl = "https://api.foursquare.com/v2/venues/" + venueId + "/tips";
            var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).TipsVenuesDictionary(sort,limit,offset);
            return ResultService.GetResult<VenueTipsModel>(serverUrl, argsDict, _httpClient);
        }
        
        #endregion

        #region Venue Actions
        ////Post
        //public void LikeVenue(string venueId, bool? set = null)
        //{
        //    if (!IsAuthenticated())
        //        return;//todo exception
        //    string serverUrl = "https://api.foursquare.com/v2/venues/" + venueId + "/like";
        //    var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).DislikeVenueDictionary(set);
        //    ResultService.PostResult(serverUrl,argsDict,_httpClient);
        //}

        ////Post
        //public void DislikeVenue(string venueId, bool? set = null)
        //{
        //    if (!IsAuthenticated())
        //        return;//todo exception
        //    string serverUrl = "https://api.foursquare.com/v2/venues/" + venueId + "/dislike";
        //    var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).DislikeVenueDictionary(set);
        //    ResultService.PostResult(serverUrl, argsDict, _httpClient);
        //}

        ////Post
        //public void EditVenue(string venueId, string name = null, string address = null, string crossStreet = null, string city = null, string state = null, string zip = null,
        //                        string phone = null, double? latitude = null, double? longitude = null, string twitter = null, string categoryId = null, string description = null,
        //                        string url = null, string storeId = null, string hours = null)
        //{
        //    if (!IsAuthenticated())
        //        return;//todo exception
        //    string serverUrl = "https://api.foursquare.com/v2/venues/" + venueId + "/edit";
        //    var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).EditVenueDictionary(name,address,crossStreet,city,state,zip,phone,latitude,longitude,twitter,
        //                                                                                                                categoryId,description,url,storeId,hours);
        //    ResultService.PostResult(serverUrl, argsDict, _httpClient);
        //}

        ////Post
        //public void FlagVenue(string venueId, string problem, string duplicatedVenueId)
        //{
        //    if (!IsAuthenticated())
        //        return;//todo exception
        //    string serverUrl = "https://api.foursquare.com/v2/venues/" + venueId + "/flag";
        //    var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).FlagVenueDictionary(problem,duplicatedVenueId);
        //    ResultService.PostResult(serverUrl, argsDict, _httpClient);
        //}

        ////Post
        //public void ProposeEditVenue(string venueId, string name = null, string address = null, string crossStreet = null, string city = null, string state = null, string zip = null,
        //                                string phone = null, double? latitude = null, double? longitude = null, string primaryCategoryId = null, string hours = null)
        //{
        //    if (!IsAuthenticated())
        //        return;//todo exception
        //    string serverUrl = "https://api.foursquare.com/v2/venues/" + venueId + "/proposeedit";
        //    var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).ProposeEditVenueDictionary(name, address, crossStreet, city, state, zip, phone, latitude, longitude,
        //                                                                                                                        primaryCategoryId, hours);
        //    ResultService.PostResult(serverUrl, argsDict, _httpClient);
        //}

        ////Post
        //public void SetRoleForVenue(string venueId, string userId, string role, bool? visible = null)
        //{
        //    if (!IsAuthenticated())
        //        return;//todo exception
        //    string serverUrl = "https://api.foursquare.com/v2/venues/" + venueId + "/setrole";
        //    var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).SetRoleVenueDictionary(userId, role,visible);
        //    ResultService.PostResult(serverUrl, argsDict, _httpClient);
        //}

        ////Post
        //public void SetSingleLocation(string venueId)
        //{
        //    if (!IsAuthenticated())
        //        return;//todo exception
        //    string serverUrl = "https://api.foursquare.com/v2/venues/" + venueId + "/setsinglelocation";
        //    var argsDict = new VenuesArgsDictionaryService(_clientId, _clientSecret, _accessToken).EmptyVenuesDictionary();
        //    ResultService.PostResult(serverUrl, argsDict, _httpClient);
        //}
        #endregion
        private bool IsAuthenticated()
        {
            return !string.IsNullOrEmpty(_accessToken);
        }
    }
}
