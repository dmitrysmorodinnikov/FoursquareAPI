using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FoursquareApi.Services.Venues
{
    internal class VenuesArgsDictionaryService
    {
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly string _accessToken;

        public VenuesArgsDictionaryService(string clientId, string clientSecret, string accessToken)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            _accessToken = accessToken;
        }

        internal Dictionary<string, string> SearchVenuesDictionary(double latitude, double longitude, string query, int? limit, string intent, double? radius, string categoryId, string url, string providerId, string linkedId)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberGroupSeparator = ".";
            var argsDictionary = new Dictionary<string, string>();
           
            string ll = string.Join(",", latitude.ToString(nfi), longitude.ToString(nfi));
            argsDictionary.Add("ll", ll);

            if(!string.IsNullOrEmpty(query))
                argsDictionary.Add("query", query);

            if(limit != null)
                argsDictionary.Add("limit", limit.ToString());
           
            if(intent != "checkin")
                argsDictionary.Add("intent", intent);

            if (radius != null && radius < 100000 && (intent == "checkin" || intent == "browse") && (!string.IsNullOrEmpty(categoryId) || !string.IsNullOrEmpty(query)))
                argsDictionary.Add("radius", radius.Value.ToString(nfi));

            if(intent != "match" && !string.IsNullOrEmpty(categoryId))
                argsDictionary.Add("categoryId", categoryId);

            if(!string.IsNullOrEmpty(url))
                argsDictionary.Add("url", url);

            // todo: providerId?

            //todo: linkedId?

            var v = DateTime.Now.Date.ToString("yyyyMMdd");
            argsDictionary.Add("v", v);

            if (string.IsNullOrEmpty(_accessToken))
            {
                argsDictionary.Add("client_id", _clientId);
                argsDictionary.Add("client_secret", _clientSecret);
            }
            else
            {
                argsDictionary.Add("oauth_token", _accessToken);
            }
            
            return argsDictionary;
        }


        internal Dictionary<string, string> SearchVenuesDictionary(string near,string query,int? limit, string intent, double? radius, string sw,string ne, string categoryId,string url,string providerId,string linkedId)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberGroupSeparator = ".";
            var argsDictionary = new Dictionary<string, string>();
            
            argsDictionary.Add("near", near);

            if (!string.IsNullOrEmpty(query))
                argsDictionary.Add("query", query);

            if (limit != null)
                argsDictionary.Add("limit", limit.ToString());

            if (intent != "checkin")
                argsDictionary.Add("intent", intent);
            
            if(radius != null && radius < 100000 && (intent == "checkin" || intent == "browse") && (!string.IsNullOrEmpty(categoryId) || !string.IsNullOrEmpty(query)))
                argsDictionary.Add("radius",radius.Value.ToString(nfi));

            if (intent != "match" && !string.IsNullOrEmpty(categoryId))
                argsDictionary.Add("categoryId", categoryId);

            if(radius!=null && intent == "browse")
                argsDictionary.Add("sw",sw);

            if (radius != null && intent == "browse")
                argsDictionary.Add("ne", ne);

            if (!string.IsNullOrEmpty(url))
                argsDictionary.Add("url", url);

            // todo: providerId?

            //todo: linkedId?

            var v = DateTime.Now.Date.ToString("yyyyMMdd");
            argsDictionary.Add("v", v);

            if (string.IsNullOrEmpty(_accessToken))
            {
                argsDictionary.Add("client_id", _clientId);
                argsDictionary.Add("client_secret", _clientSecret);
            }
            else
            {
                argsDictionary.Add("oauth_token", _accessToken);
            }
            return argsDictionary;
        }

        internal Dictionary<string, string> VenueDetailDictionary()
        {
           var v = DateTime.Now.Date.ToString("yyyyMMdd");
           if (string.IsNullOrEmpty(_accessToken))
               return new Dictionary<string, string>() { { "client_id", _clientId }, { "client_secret", _clientSecret },{"v", v}};
           return new Dictionary<string, string>() { { "oauth_token", _accessToken }, { "v", v } };
        }

        internal Dictionary<string, string> TrendingVenuesDictionary(double latitude, double longitude, short? limit, short? radius)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberGroupSeparator = ".";
            var argsDictionary = new Dictionary<string, string>();

            string ll = string.Join(",", latitude.ToString(nfi), longitude.ToString(nfi));
            argsDictionary.Add("ll", ll);

            if (limit != null)
            {
                if (limit > 50)
                    limit = 50;
                argsDictionary.Add("limit", limit.ToString());
            }

            if (radius != null)
            {
                if (radius > 2000)
                    radius = 2000;
                argsDictionary.Add("radius", radius.ToString());
            }

            var v = DateTime.Now.Date.ToString("yyyyMMdd");
            argsDictionary.Add("v", v);

            if (string.IsNullOrEmpty(_accessToken))
            {
                argsDictionary.Add("client_id", _clientId);
                argsDictionary.Add("client_secret", _clientSecret);
            }
            else
            {
                argsDictionary.Add("oauth_token",_accessToken);
            }
            return argsDictionary;
        }

        internal Dictionary<string, string> VenuesCategoriesDictionary()
        {
            var v = DateTime.Now.Date.ToString("yyyyMMdd");
            var argsDictionary = new Dictionary<string, string>(){{ "v", v }};
            if (string.IsNullOrEmpty(_accessToken))
            {
                argsDictionary.Add("client_id", _clientId);
                argsDictionary.Add("client_secret", _clientSecret);
            }
            else
            {
                argsDictionary.Add("oauth_token", _accessToken);
            }

            return argsDictionary;
        }

        internal Dictionary<string, string> ExploreVenuesDictionary(double latitude, double longitude, double? lAcc, double? alt, double? altAcc, double? radius, string section,
                                                string query, int? limit, int? offset, string novelty, string friendVisits, string time, string day,
                                                bool? venuePhotos, string lastVenue, bool? openNow, bool? sortByDistance, int[] price, bool? saved,
                                                bool? specials)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberGroupSeparator = ".";
            var argsDictionary = new Dictionary<string, string>();
            var v = DateTime.Now.Date.ToString("yyyyMMdd");
            argsDictionary.Add("v", v);

            string ll = string.Join(",", latitude.ToString(nfi), longitude.ToString(nfi));
            argsDictionary.Add("ll", ll);

            if (lAcc != null)
                argsDictionary.Add("lAcc", lAcc.Value.ToString(nfi));

            if (alt != null)
                argsDictionary.Add("alt", alt.Value.ToString(nfi));

            if (altAcc != null)
                argsDictionary.Add("altAcc", altAcc.Value.ToString(nfi));

            if (radius != null)
                argsDictionary.Add("radius", radius.Value.ToString(nfi));

            if (!string.IsNullOrEmpty(section))
                argsDictionary.Add("section", section);

            if (!string.IsNullOrEmpty(query))
                argsDictionary.Add("query", query);

            if (limit != null)
                argsDictionary.Add("limit", limit.ToString());

            if (offset != null)
                argsDictionary.Add("offset", offset.ToString());

            if (!string.IsNullOrEmpty(novelty))
                argsDictionary.Add("novelty", novelty);

            if (!string.IsNullOrEmpty(friendVisits))
                argsDictionary.Add("friendVisits", friendVisits);

            if (!string.IsNullOrEmpty(time))
                argsDictionary.Add("time", time);

            if (!string.IsNullOrEmpty(day))
                argsDictionary.Add("day", day);

            if (venuePhotos != null)
                argsDictionary.Add("venuePhotos", venuePhotos.Value.ToString());

            if (!string.IsNullOrEmpty(lastVenue))
                argsDictionary.Add("lastVenue", lastVenue);

            if (openNow != null)
                argsDictionary.Add("openNow", openNow.Value.ToString());

            if (sortByDistance != null)
                argsDictionary.Add("sortByDistance", sortByDistance.Value.ToString());

            if (price != null)
            {
                StringBuilder priceStrBuilder = new StringBuilder();
                foreach (var priceItem in price)
                {
                    priceStrBuilder.Append(priceItem.ToString());
                    priceStrBuilder.Append(',');
                }
                var priceStr = priceStrBuilder.ToString(0,priceStrBuilder.Length-1);
                argsDictionary.Add("price",priceStr);
            }

            if (saved != null)
                argsDictionary.Add("saved", saved.Value.ToString());

            if (specials != null)
                argsDictionary.Add("specials", specials.Value.ToString());

            if (string.IsNullOrEmpty(_accessToken))
            {
                argsDictionary.Add("client_id", _clientId);
                argsDictionary.Add("client_secret", _clientSecret);
            }
            else
            {
                argsDictionary.Add("oauth_token", _accessToken);
            }

            return argsDictionary;
        }

        internal Dictionary<string, string> ExploreVenuesDictionary(string near, double? lAcc, double? alt, double? altAcc, double? radius, string section,
                                               string query, int? limit, int? offset, string novelty, string friendVisits, string time, string day,
                                               bool? venuePhotos, string lastVenue, bool? openNow, bool? sortByDistance, int[] price, bool? saved,
                                               bool? specials)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberGroupSeparator = ".";
            var argsDictionary = new Dictionary<string, string>();
            var v = DateTime.Now.Date.ToString("yyyyMMdd");
            argsDictionary.Add("v", v);
            
            argsDictionary.Add("near", near);

            if (lAcc != null)
                argsDictionary.Add("lAcc", lAcc.Value.ToString(nfi));

            if (alt != null)
                argsDictionary.Add("alt", alt.Value.ToString(nfi));

            if (altAcc != null)
                argsDictionary.Add("altAcc", altAcc.Value.ToString(nfi));

            if (radius != null)
                argsDictionary.Add("radius", radius.Value.ToString(nfi));

            if (!string.IsNullOrEmpty(section))
                argsDictionary.Add("section", section);

            if (!string.IsNullOrEmpty(query))
                argsDictionary.Add("query", query);

            if (limit != null)
                argsDictionary.Add("limit", limit.ToString());

            if (offset != null)
                argsDictionary.Add("offset", offset.ToString());

            if (!string.IsNullOrEmpty(novelty))
                argsDictionary.Add("novelty", novelty);

            if (!string.IsNullOrEmpty(friendVisits))
                argsDictionary.Add("friendVisits", friendVisits);

            if (!string.IsNullOrEmpty(time))
                argsDictionary.Add("time", time);

            if (!string.IsNullOrEmpty(day))
                argsDictionary.Add("day", day);

            if (venuePhotos != null)
                argsDictionary.Add("venuePhotos", venuePhotos.Value.ToString());

            if (!string.IsNullOrEmpty(lastVenue))
                argsDictionary.Add("lastVenue", lastVenue);

            if (openNow != null)
                argsDictionary.Add("openNow", openNow.Value.ToString());

            if (sortByDistance != null)
                argsDictionary.Add("sortByDistance", sortByDistance.Value.ToString());

            if (price != null)
            {
                StringBuilder priceStrBuilder = new StringBuilder();
                foreach (var priceItem in price)
                {
                    priceStrBuilder.Append(priceItem.ToString());
                    priceStrBuilder.Append(',');
                }
                var priceStr = priceStrBuilder.ToString(0, priceStrBuilder.Length - 1);
                argsDictionary.Add("price", priceStr);
            }

            if (saved != null)
                argsDictionary.Add("saved", saved.Value.ToString());

            if (specials != null)
                argsDictionary.Add("specials", specials.Value.ToString());

            if (string.IsNullOrEmpty(_accessToken))
            {
                argsDictionary.Add("client_id", _clientId);
                argsDictionary.Add("client_secret", _clientSecret);
            }
            else
            {
                argsDictionary.Add("oauth_token", _accessToken);
            }

            return argsDictionary;
        }

        internal Dictionary<string, string> SuggestCompletionDictionary(double latitude, double longitude, string query, double? lAcc,
                                                                                double? alt, double? altAcc, int? limit, int? radius)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberGroupSeparator = ".";
            var argsDictionary = new Dictionary<string, string>();
            var v = DateTime.Now.Date.ToString("yyyyMMdd");
            argsDictionary.Add("v", v);

            string ll = string.Join(",", latitude.ToString(nfi), longitude.ToString(nfi));
            argsDictionary.Add("ll", ll);

            argsDictionary.Add("query", query);

            if (lAcc != null)
                argsDictionary.Add("lAcc", lAcc.Value.ToString(nfi));

            if (alt != null)
                argsDictionary.Add("alt", alt.Value.ToString(nfi));

            if (altAcc != null)
                argsDictionary.Add("altAcc", altAcc.Value.ToString(nfi));

            if (radius != null)
                argsDictionary.Add("radius", radius.Value.ToString());

            if (limit != null)
                argsDictionary.Add("limit", limit.Value.ToString(nfi));

            if (string.IsNullOrEmpty(_accessToken))
            {
                argsDictionary.Add("client_id", _clientId);
                argsDictionary.Add("client_secret", _clientSecret);
            }
            else
            {
                argsDictionary.Add("oauth_token", _accessToken);
            }

            return argsDictionary;
        }

        internal Dictionary<string, string> SuggestCompletionDictionary(string near, string query, double? lAcc,
                                                                                double? alt, double? altAcc, int? limit, int? radius,string ne, string sw)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberGroupSeparator = ".";
            var argsDictionary = new Dictionary<string, string>();

           argsDictionary.Add("near",near);

            argsDictionary.Add("query", query);

            if (lAcc != null)
                argsDictionary.Add("lAcc", lAcc.Value.ToString(nfi));

            if (alt != null)
                argsDictionary.Add("alt", alt.Value.ToString(nfi));

            if (altAcc != null)
                argsDictionary.Add("altAcc", altAcc.Value.ToString(nfi));

            if (radius != null)
                argsDictionary.Add("radius", radius.Value.ToString());

            if (limit != null)
                argsDictionary.Add("limit", limit.Value.ToString(nfi));

            if (!string.IsNullOrEmpty(ne) && radius == null)
            {
                argsDictionary.Add("ne",ne);
            }

            if (!string.IsNullOrEmpty(sw) && radius == null)
            {
                argsDictionary.Add("sw", sw);
            }

            var v = DateTime.Now.Date.ToString("yyyyMMdd");
            argsDictionary.Add("v", v);

            if (string.IsNullOrEmpty(_accessToken))
            {
                argsDictionary.Add("client_id", _clientId);
                argsDictionary.Add("client_secret", _clientSecret);
            }
            else
            {
                argsDictionary.Add("oauth_token", _accessToken);
            }

            return argsDictionary;
        }

        internal Dictionary<string,string> AddVenueDictionary(string name, double latitude, double longitude, string address, string crossStreet, string city, string state, string zip, string phone,
                                        string twitter, string primaryCategoryId, string description, string url, bool? ignoreDuplicates, string ignoreDuplicatesKey)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberGroupSeparator = ".";
            var argsDictionary = new Dictionary<string, string>();
            argsDictionary.Add("oauth_token", _accessToken);
            var v = DateTime.Now.Date.ToString("yyyyMMdd");
            argsDictionary.Add("v", v);

            argsDictionary.Add("name",name);

            string ll = string.Join(",", latitude.ToString(nfi), longitude.ToString(nfi));
            argsDictionary.Add("ll", ll);

            if(!string.IsNullOrEmpty(address))
                argsDictionary.Add("address",address);

            if (!string.IsNullOrEmpty(crossStreet))
                argsDictionary.Add("crossStreet", crossStreet);

            if (!string.IsNullOrEmpty(city))
                argsDictionary.Add("city", city);

            if (!string.IsNullOrEmpty(state))
                argsDictionary.Add("state", state);

            if (!string.IsNullOrEmpty(zip))
                argsDictionary.Add("zip", zip);

            if (!string.IsNullOrEmpty(phone))
                argsDictionary.Add("phone", phone);

            if (!string.IsNullOrEmpty(twitter))
                argsDictionary.Add("twitter", twitter);

            if (!string.IsNullOrEmpty(primaryCategoryId))
                argsDictionary.Add("primaryCategoryId", primaryCategoryId);

            if (!string.IsNullOrEmpty(description))
                argsDictionary.Add("description", description);

            if (!string.IsNullOrEmpty(url))
                argsDictionary.Add("url", url);

            if(ignoreDuplicates.HasValue)
                argsDictionary.Add("ignoreDuplicates", ignoreDuplicates.ToString());

            if (!string.IsNullOrEmpty(ignoreDuplicatesKey))
                argsDictionary.Add("ignoreDuplicatesKey", ignoreDuplicatesKey);

            return argsDictionary;
        }

        public Dictionary<string, string> ManagedVenuesDictionary(int? limit, int? offset)
        {
            var argsDictionary = new Dictionary<string, string>();
            argsDictionary.Add("oauth_token", _accessToken);
            var v = DateTime.Now.Date.ToString("yyyyMMdd");
            argsDictionary.Add("v", v);

            if(limit.HasValue)
                argsDictionary.Add("limit",limit.Value.ToString());
            if(offset.HasValue)
                argsDictionary.Add("offset",offset.Value.ToString());

            return argsDictionary;
        }

        public Dictionary<string, string> TimeseriesVenuesDictionary(long startAt, long? endAt, string venueId, string fields)
        {
            var argsDictionary = new Dictionary<string, string>();
            argsDictionary.Add("oauth_token", _accessToken);
            var v = DateTime.Now.Date.ToString("yyyyMMdd");
            argsDictionary.Add("v", v);

            argsDictionary.Add("startAt",startAt.ToString());

            if(endAt.HasValue)
                argsDictionary.Add("endAt",endAt.ToString());

            if(!string.IsNullOrEmpty(venueId))
                argsDictionary.Add("venueId",venueId);

            if(!string.IsNullOrEmpty(fields))
                argsDictionary.Add("fields",fields);

            return argsDictionary;
        }

        public Dictionary<string, string> HereNowVenuesDictionary(int? limit, int? offset)
        {
            var argsDictionary = new Dictionary<string, string>();
            argsDictionary.Add("oauth_token", _accessToken);
            var v = DateTime.Now.Date.ToString("yyyyMMdd");
            argsDictionary.Add("v", v);

            if (limit.HasValue)
                argsDictionary.Add("limit", limit.ToString());

            if (offset.HasValue)
                argsDictionary.Add("offset", offset.ToString());
            return argsDictionary;
        }

        public Dictionary<string, string> EmptyVenuesDictionary()
        {
            var argsDictionary = new Dictionary<string, string>();
            var v = DateTime.Now.Date.ToString("yyyyMMdd");
            argsDictionary.Add("v", v);

            if (string.IsNullOrEmpty(_accessToken))
            {
                argsDictionary.Add("client_id", _clientId);
                argsDictionary.Add("client_secret", _clientSecret);
            }
            else
            {
                argsDictionary.Add("oauth_token", _accessToken);
            }

            return argsDictionary;
        }

        public Dictionary<string, string> ListsVenuesDictionary(string group, int? limit, int? offset)
        {
            var argsDictionary = new Dictionary<string, string>();
            var v = DateTime.Now.Date.ToString("yyyyMMdd");
            argsDictionary.Add("v", v);

            if (string.IsNullOrEmpty(_accessToken))
            {
                argsDictionary.Add("client_id", _clientId);
                argsDictionary.Add("client_secret", _clientSecret);
            }
            else
            {
                argsDictionary.Add("oauth_token", _accessToken);
            }

            if (!string.IsNullOrEmpty(group))
                argsDictionary.Add("group",group);

            if (limit.HasValue)
                argsDictionary.Add("limit",limit.Value.ToString());
            
            if(offset.HasValue)
                argsDictionary.Add("offset",offset.Value.ToString());

            return argsDictionary;
        }

        public Dictionary<string, string> PhotosVenuesDictionary(string group, int? limit, int? offset)
        {
            var argsDictionary = new Dictionary<string, string>();
            var v = DateTime.Now.Date.ToString("yyyyMMdd");
            argsDictionary.Add("v", v);

            if (string.IsNullOrEmpty(_accessToken))
            {
                argsDictionary.Add("client_id", _clientId);
                argsDictionary.Add("client_secret", _clientSecret);
            }
            else
            {
                argsDictionary.Add("oauth_token", _accessToken);
            }

            if (!string.IsNullOrEmpty(group))
                argsDictionary.Add("group", group);

            if (limit.HasValue)
                argsDictionary.Add("limit", limit.Value.ToString());

            if (offset.HasValue)
                argsDictionary.Add("offset", offset.Value.ToString());

            return argsDictionary;
        }

        public Dictionary<string, string> StatsVenuesDictionary(long? startAt, long? endAt)
        {
            var argsDictionary = new Dictionary<string, string>();
            var v = DateTime.Now.Date.ToString("yyyyMMdd");
            argsDictionary.Add("v", v);
            argsDictionary.Add("oauth_token", _accessToken);

            if(startAt.HasValue)
                argsDictionary.Add("startAt",startAt.Value.ToString());
            if (endAt.HasValue)
                argsDictionary.Add("endAt", endAt.Value.ToString());
            return argsDictionary;
        }

        public Dictionary<string, string> TipsVenuesDictionary(string sort, int? limit, int? offset)
        {
            var argsDictionary = new Dictionary<string, string>();
            var v = DateTime.Now.Date.ToString("yyyyMMdd");
            argsDictionary.Add("v", v);

            if (string.IsNullOrEmpty(_accessToken))
            {
                argsDictionary.Add("client_id", _clientId);
                argsDictionary.Add("client_secret", _clientSecret);
            }
            else
            {
                argsDictionary.Add("oauth_token", _accessToken);
            }

            if(!string.IsNullOrEmpty(sort))
                argsDictionary.Add("sort",sort);

            if (limit.HasValue)
                argsDictionary.Add("limit", limit.Value.ToString());

            if (offset.HasValue)
                argsDictionary.Add("offset", offset.Value.ToString());

            return argsDictionary;
        }

        public Dictionary<string, string> DislikeVenueDictionary(bool? set)
        {
            var argsDictionary = new Dictionary<string, string>();
            var v = DateTime.Now.Date.ToString("yyyyMMdd");
            argsDictionary.Add("v", v);
            argsDictionary.Add("oauth_token", _accessToken);
            if(set.HasValue)
                argsDictionary.Add("set",set.Value.ToString());
            return argsDictionary;
        }

        public Dictionary<string, string> SetRoleVenueDictionary(string userId, string role, bool? visible)
        {
            var argsDictionary = new Dictionary<string, string>();
            var v = DateTime.Now.Date.ToString("yyyyMMdd");
            argsDictionary.Add("v", v);
            argsDictionary.Add("oauth_token", _accessToken);
            argsDictionary.Add("userId",userId);
            argsDictionary.Add("role",role);
            if(visible.HasValue)
                argsDictionary.Add("visible",visible.Value.ToString());
            return argsDictionary;
        }

        public Dictionary<string, string> FlagVenueDictionary(string problem, string duplicatedVenueId)
        {
            var argsDictionary = new Dictionary<string, string>();
            var v = DateTime.Now.Date.ToString("yyyyMMdd");
            argsDictionary.Add("v", v);
            argsDictionary.Add("oauth_token", _accessToken);
            argsDictionary.Add("problem",problem);
            if(!string.IsNullOrEmpty(duplicatedVenueId))
            argsDictionary.Add("venueId", duplicatedVenueId);
            return argsDictionary;
        }

        public Dictionary<string, string> EditVenueDictionary(string name, string address, string crossStreet, string city, string state, string zip, string phone, double? latitude,
                                                                double? longitude, string twitter, string categoryId, string description, string url, string storeId, string hours)
        {
            var argsDictionary = new Dictionary<string, string>();
            var v = DateTime.Now.Date.ToString("yyyyMMdd");
            argsDictionary.Add("v", v);
            argsDictionary.Add("oauth_token", _accessToken);
            if(!string.IsNullOrEmpty(name))
                argsDictionary.Add("name",name);

            if (!string.IsNullOrEmpty(address))
                argsDictionary.Add("address", address);

            if (!string.IsNullOrEmpty(crossStreet))
                argsDictionary.Add("crossStreet", crossStreet);

            if (!string.IsNullOrEmpty(city))
                argsDictionary.Add("city", city);

            if (!string.IsNullOrEmpty(state))
                argsDictionary.Add("state", state);

            if (!string.IsNullOrEmpty(zip))
                argsDictionary.Add("zip", zip);

            if (!string.IsNullOrEmpty(phone))
                argsDictionary.Add("phone", phone);

            if (!string.IsNullOrEmpty(twitter))
                argsDictionary.Add("twitter", twitter);

            if (!string.IsNullOrEmpty(categoryId))
                argsDictionary.Add("categoryId", categoryId);

            if (!string.IsNullOrEmpty(description))
                argsDictionary.Add("description", description);
            if (!string.IsNullOrEmpty(url))
                argsDictionary.Add("url", url);
            if (!string.IsNullOrEmpty(storeId))
                argsDictionary.Add("storeId", storeId);
            if (!string.IsNullOrEmpty(hours))
                argsDictionary.Add("hours", hours);

            if (latitude.HasValue && longitude.HasValue)
            {
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberGroupSeparator = ".";
                string ll = string.Join(",", latitude.Value.ToString(nfi), longitude.Value.ToString(nfi));
                argsDictionary.Add("ll", ll);
            }

            return argsDictionary;
        }

        public Dictionary<string, string> ProposeEditVenueDictionary(string name, string address, string crossStreet, string city, string state, string zip, string phone,
                                                                    double? latitude, double? longitude, string primaryCategoryId, string hours)
        {
            var argsDictionary = new Dictionary<string, string>();
            var v = DateTime.Now.Date.ToString("yyyyMMdd");
            argsDictionary.Add("v", v);
            argsDictionary.Add("oauth_token", _accessToken);
            if (!string.IsNullOrEmpty(name))
                argsDictionary.Add("name", name);

            if (!string.IsNullOrEmpty(address))
                argsDictionary.Add("address", address);

            if (!string.IsNullOrEmpty(crossStreet))
                argsDictionary.Add("crossStreet", crossStreet);

            if (!string.IsNullOrEmpty(city))
                argsDictionary.Add("city", city);

            if (!string.IsNullOrEmpty(state))
                argsDictionary.Add("state", state);

            if (!string.IsNullOrEmpty(zip))
                argsDictionary.Add("zip", zip);

            if (!string.IsNullOrEmpty(phone))
                argsDictionary.Add("phone", phone);

            if (!string.IsNullOrEmpty(primaryCategoryId))
                argsDictionary.Add("primaryCategoryId", primaryCategoryId);
            if (!string.IsNullOrEmpty(hours))
                argsDictionary.Add("hours", hours);

            if (latitude.HasValue && longitude.HasValue)
            {
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberGroupSeparator = ".";
                string ll = string.Join(",", latitude.Value.ToString(nfi), longitude.Value.ToString(nfi));
                argsDictionary.Add("ll", ll);
            }

            return argsDictionary;
        }
    }
}
