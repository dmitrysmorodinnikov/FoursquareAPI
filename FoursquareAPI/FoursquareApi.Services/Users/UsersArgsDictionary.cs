using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApi.Services.Users
{
   internal class UsersArgsDictionary
    {
        private readonly string _accessToken;

       internal UsersArgsDictionary( string accessToken)
        {
            _accessToken = accessToken;
        }
       internal Dictionary<string,string> UserInfoArgsDictionary()
       {
           var dict = new Dictionary<string, string>();
           var v = DateTime.Now.Date.ToString("yyyyMMdd");
           dict.Add("oauth_token", _accessToken);
           dict.Add("v", v);
           //dict.Add("USER_ID",userId);

           return dict;
       }

       internal Dictionary<string, string> UpdatePhotoArgsDictionary(string photo)
       {
           var v = DateTime.Now.Date.ToString("yyyyMMdd");
           return new Dictionary<string, string>()
            {
                { "oauth_token", _accessToken },
                {"photo", photo},
                {"v", v}
            };
       }

       internal Dictionary<string, string> SetPingsArgsDictionary(bool value)
       {
           var v = DateTime.Now.Date.ToString("yyyyMMdd");
           return new Dictionary<string, string>()
            {
                { "oauth_token", _accessToken },
                {"value", value.ToString()},
                {"v", v}
            };
       }

       public Dictionary<string,string> UserCheckinsArgsDictionary(int? limit, int? offset, string sort, long? afterTimestamp, long? beforeTimestamp)
       {
           var v = DateTime.Now.Date.ToString("yyyyMMdd");
           var dict = new Dictionary<string, string>()
           {
               {"oauth_token", _accessToken},
               {"v", v}
           };

           if(limit != null)
               dict.Add("limit",limit.ToString());
           if(offset != null)
               dict.Add("offset",offset.ToString());
           if (afterTimestamp != null)
               dict.Add("afterTimestamp", afterTimestamp.ToString());
           if (beforeTimestamp != null)
               dict.Add("beforeTimestamp", beforeTimestamp.ToString());

           return dict;
       }

       public Dictionary<string, string> UserFriendsArgsDictionary(int? limit, int? offset)
       {
           var v = DateTime.Now.Date.ToString("yyyyMMdd");
           var dict = new Dictionary<string, string>()
           {
               {"oauth_token", _accessToken},
               {"v", v}
           };

           if (limit != null)
               dict.Add("limit", limit.ToString());
           if (offset != null)
               dict.Add("offset", offset.ToString());
           return dict;
       }

       public Dictionary<string, string> UserListsArgsDictionary(string group, double? latitude, double? longitude)
       {
           var v = DateTime.Now.Date.ToString("yyyyMMdd");
           var dict = new Dictionary<string, string>()
           {
               {"oauth_token", _accessToken},
               {"v", v}
           };
           if(!string.IsNullOrEmpty(group))
               dict.Add("group",group);

           if (latitude.HasValue && longitude.HasValue)
           {
               NumberFormatInfo nfi = new NumberFormatInfo();
               nfi.NumberGroupSeparator = ".";

               string ll = string.Join(",", latitude.Value.ToString(nfi), longitude.Value.ToString(nfi));
               dict.Add("ll", ll);
           }
           return dict;
       }

       public Dictionary<string, string> UserPhotosArgsDictionary(int? limit, int? offset)
       {
           var v = DateTime.Now.Date.ToString("yyyyMMdd");
           var dict = new Dictionary<string, string>()
           {
               {"oauth_token", _accessToken},
               {"v", v}
           };

           if (limit != null)
               dict.Add("limit", limit.ToString());
           if (offset != null)
               dict.Add("offset", offset.ToString());
           return dict;
       }

       public Dictionary<string, string> UserTipsArgsDictionary(int? limit, int? offset, double? latitude, double? longitude, string sort)
       {
           var v = DateTime.Now.Date.ToString("yyyyMMdd");
           var dict = new Dictionary<string, string>()
           {
               {"oauth_token", _accessToken},
               {"v", v}
           };

           if (limit != null)
               dict.Add("limit", limit.ToString());
           if (offset != null)
               dict.Add("offset", offset.ToString());
           if (latitude.HasValue && longitude.HasValue)
           {
               NumberFormatInfo nfi = new NumberFormatInfo();
               nfi.NumberGroupSeparator = ".";

               string ll = string.Join(",", latitude.Value.ToString(nfi), longitude.Value.ToString(nfi));
               dict.Add("ll", ll);
           }
           if(!string.IsNullOrEmpty(sort))
               dict.Add("sort",sort);
           return dict;
       }

       public Dictionary<string, string> UserTodosArgsDictionary(double? latitude, double? longitude, string sort)
       {
           var v = DateTime.Now.Date.ToString("yyyyMMdd");
           var dict = new Dictionary<string, string>()
           {
               {"oauth_token", _accessToken},
               {"v", v}
           };
           
           if (latitude.HasValue && longitude.HasValue)
           {
               NumberFormatInfo nfi = new NumberFormatInfo();
               nfi.NumberGroupSeparator = ".";

               string ll = string.Join(",", latitude.Value.ToString(nfi), longitude.Value.ToString(nfi));
               dict.Add("ll", ll);
           }

           if (!string.IsNullOrEmpty(sort))
               dict.Add("sort", sort);
           return dict;
       }

       public Dictionary<string, string> UserVenueHistoryArgsDictionary(string categoryId, long? afterTimestamp, long? beforeTimestamp)
       {
           var v = DateTime.Now.Date.ToString("yyyyMMdd");
           var dict = new Dictionary<string, string>()
           {
               {"oauth_token", _accessToken},
               {"v", v}
           };

           if (!string.IsNullOrEmpty(categoryId))
               dict.Add("categoryId", categoryId);

           if(afterTimestamp.HasValue)
               dict.Add("afterTimestamp", afterTimestamp.ToString());

           if (beforeTimestamp.HasValue)
               dict.Add("beforeTimestamp", beforeTimestamp.ToString());

           return dict;
       }

       public Dictionary<string, string> UserLeaderboardArgsDictionary(int? neighbors)
       {
           var v = DateTime.Now.Date.ToString("yyyyMMdd");
           var dict = new Dictionary<string, string>()
           {
               {"oauth_token", _accessToken},
               {"v", v}
           };

           if (neighbors.HasValue)
               dict.Add("neighbors", neighbors.ToString());

           return dict;
       }

       public Dictionary<string, string> UserRequestsArgsDictionary()
       {
           var dict = new Dictionary<string, string>();
           var v = DateTime.Now.Date.ToString("yyyyMMdd");
           dict.Add("oauth_token", _accessToken);
           dict.Add("v", v);

           return dict;
       }

       public Dictionary<string, string> SearchUsersArgsDictionary(string phone, string email, string twitter, string twitterSource, string fbid, string name)
       {
           var dict = new Dictionary<string, string>();
           var v = DateTime.Now.Date.ToString("yyyyMMdd");
           dict.Add("oauth_token", _accessToken);
           dict.Add("v", v);

           if (!string.IsNullOrEmpty(phone))
           {
               dict.Add("phone",phone);
           }

           if (!string.IsNullOrEmpty(email))
           {
               dict.Add("email", email);
           }

           if (!string.IsNullOrEmpty(twitter))
           {
               dict.Add("twitter", twitter);
           }

           if (!string.IsNullOrEmpty(twitterSource))
           {
               dict.Add("twitterSource", twitterSource);
           }

           if (!string.IsNullOrEmpty(name))
           {
               dict.Add("name", name);
           }
           return dict;
       }
    }
}
