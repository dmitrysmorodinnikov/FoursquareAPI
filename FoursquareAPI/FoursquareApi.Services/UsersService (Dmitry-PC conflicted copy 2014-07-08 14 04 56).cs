using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Users;
using FoursquareApi.Models.Venues;
using FoursquareApi.Services.Users;
using HttpClient;
using HttpClient.SerializationService;

namespace FoursquareApi.Services
{
    public class UsersService : FoursquareApiService
    {
        public UsersService(string accessToken)
        {
            Initialize(accessToken);
        }

        //Checked
        public UserInfoModel User(string userId)
        {
            if(!IsAuthenticated())
                return null;

            if (userId == null)
                userId = "self";
            string serverUrl = "https://api.foursquare.com/v2/users/" + userId;
            var argsDict = new UsersArgsDictionary(_accessToken).UserInfoArgsDictionary();
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(serverUrl, queryString);
            var userInfoModel = _httpClient.SendGetRequest<UserInfoModel>(requestUrl).Result;
            return userInfoModel;
        }

        //Checked
        public LeaderboardModel LeaderBoard(int? neighbors = null)
        {
            if (!IsAuthenticated())
                return null;

            string serverUrl = "https://api.foursquare.com/v2/users/leaderboard/";
            var argsDict = new UsersArgsDictionary(_accessToken).UserLeaderboardArgsDictionary(neighbors);
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(serverUrl, queryString);
            var leaderBoardModel = _httpClient.SendGetRequest<LeaderboardModel>(requestUrl).Result;
            return leaderBoardModel;
        }

        public FriendRequestsModel FriendRequests()
        {
            if (!IsAuthenticated())
                return null;

            string serverUrl = "https://api.foursquare.com/v2/users/requests/";
            var argsDict = new UsersArgsDictionary(_accessToken).UserRequestsArgsDictionary();
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(serverUrl, queryString);
            var friendRequestsModel = _httpClient.SendGetRequest<FriendRequestsModel>(requestUrl).Result;
            return friendRequestsModel;   
        }

        public SearchUsersModel SearchUsers(string phone = null, string email = null, string twitter = null, string twitterSource = null, string fbid = null, string name = null)
        {
            if (!IsAuthenticated())
                return null;

            string serverUrl = "https://api.foursquare.com/v2/users/search/";
            var argsDict = new UsersArgsDictionary(_accessToken).SearchUsersArgsDictionary(phone,email,twitter,twitterSource,fbid,name);
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(serverUrl, queryString);
            var searchUsersModel = _httpClient.SendGetRequest<SearchUsersModel>(requestUrl).Result;
            return searchUsersModel; 
        }

        #region Users Aspects

        public UserBadgesModel UserBadges(string userId)
        {
            var serverUrl = "https://api.foursquare.com/v2/users/" + userId + "/badges";
            var userBadgesModel = _httpClient.SendGetRequest<UserBadgesModel>(serverUrl).Result;
            return userBadgesModel;
        }

        public UserCheckinsModel UserCheckins(string userId = null, int? limit = null, int? offset = null, string sort = null, long? afterTimestamp = null, long? beforeTimestamp = null)
        {
            if (userId == null)
                userId = "self";
            var serverUrl = "https://api.foursquare.com/v2/users/" + userId + "/checkins";
            var argsDict = new UsersArgsDictionary(_accessToken).UserCheckinsArgsDictionary(limit,offset,sort,afterTimestamp,beforeTimestamp);
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(serverUrl, queryString);
            var userCheckinsModel = _httpClient.SendGetRequest<UserCheckinsModel>(requestUrl).Result;
            return userCheckinsModel;
        }

        public UserFriendsModel UserFriends(string userId = null, int? limit = null, int? offset = null)
        {
            if (userId == null)
                userId = "self";
            var serverUrl = "https://api.foursquare.com/v2/users/" + userId + "/friends";
            var argsDict = new UsersArgsDictionary(_accessToken).UserFriendsArgsDictionary(limit, offset);
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(serverUrl, queryString);
            var userFriendsModel = _httpClient.SendGetRequest<UserFriendsModel>(requestUrl).Result;
            return userFriendsModel;
        }

        public UserListsModel UserLists(string userId = null, string group = null, double? latitude = null, double? longitude = null)
        {
            if (userId == null)
                userId = "self";
            var serverUrl = "https://api.foursquare.com/v2/users/" + userId + "/lists";
            var argsDict = new UsersArgsDictionary(_accessToken).UserListsArgsDictionary(group,latitude,longitude);
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(serverUrl, queryString);
            var userListsModel = _httpClient.SendGetRequest<UserListsModel>(requestUrl).Result;
            return userListsModel;
        }

        public UserMayorshipsModel UserMayorships(string userId = null)
        {
            if (userId == null)
                userId = "self";
            var serverUrl = "https://api.foursquare.com/v2/users/" + userId + "/mayorships";
            var userMayorhipsModel = _httpClient.SendGetRequest<UserMayorshipsModel>(serverUrl).Result;
            return userMayorhipsModel;
        }

        public UserPhotosModel UserPhotos(string userId = null, int? limit = null, int? offset = null)
        {
            if (userId == null)
                userId = "self";
            var serverUrl = "https://api.foursquare.com/v2/users/" + userId + "/photos";
            var argsDict = new UsersArgsDictionary(_accessToken).UserPhotosArgsDictionary(limit, offset);
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(serverUrl, queryString);
            var userPhotosModel = _httpClient.SendGetRequest<UserPhotosModel>(requestUrl).Result;
            return userPhotosModel;
        }

        public UserTipsModel UserTips(string userId = null, int? limit = null, int? offset = null, double? latitude = null, double? longitude = null, string sort = null)
        {
            if (userId == null)
                userId = "self";
            var serverUrl = "https://api.foursquare.com/v2/users/" + userId + "/tips";
            var argsDict = new UsersArgsDictionary(_accessToken).UserTipsArgsDictionary(limit, offset,latitude,longitude,sort);
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(serverUrl, queryString);
            var userTipsModel = _httpClient.SendGetRequest<UserTipsModel>(requestUrl).Result;
            return userTipsModel;
        }

        public UserTodosModel UserTodos(string userId = null, double? latitude = null, double? longitude = null, string sort = null)
        {
            if (userId == null)
                userId = "self";
            var serverUrl = "https://api.foursquare.com/v2/users/" + userId + "/todos";
            var argsDict = new UsersArgsDictionary(_accessToken).UserTodosArgsDictionary(latitude, longitude, sort);
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(serverUrl, queryString);
            var userTodosModel = _httpClient.SendGetRequest<UserTodosModel>(requestUrl).Result;
            return userTodosModel;
        }

        public UserVenueHistoryModel UserVenueHistory(string userId = null, string categoryId = null, long? afterTimestamp = null, long? beforeTimestamp = null)
        {
            if (userId == null)
                userId = "self";
            var serverUrl = "https://api.foursquare.com/v2/users/" + userId + "/venuehistory";
            var argsDict = new UsersArgsDictionary(_accessToken).UserVenueHistoryArgsDictionary(categoryId,afterTimestamp,beforeTimestamp);
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(serverUrl, queryString);
            var userVenueHistoryModel = _httpClient.SendGetRequest<UserVenueHistoryModel>(requestUrl).Result;
            return userVenueHistoryModel;
        }
        #endregion

        #region Users Actions

        public UserInfoModel Approve(string userId)
        {
            var serverUrl = "https://api.foursquare.com/v2/users/" + userId + "/approve";
            var userInfoModel = _httpClient.SendPostRequest<UserInfoModel, object>(serverUrl, null).Result;
            return userInfoModel;
        }

        public UserInfoModel Deny(string userId)
        {
            var serverUrl = "https://api.foursquare.com/v2/users/" + userId + "/deny";
            var userInfoModel = _httpClient.SendPostRequest<UserInfoModel, object>(serverUrl, null).Result;
            return userInfoModel;
        }

        public UserInfoModel SetPings(string userId, bool value)
        {
            var serverUrl = "https://api.foursquare.com/v2/users/" + userId + "/setpings";
            var argsDict = new UsersArgsDictionary(_accessToken).SetPingsArgsDictionary(value);
            string postData = QueryStringHelper.BuildPostData(argsDict);
            var userInfoModel = _httpClient.SendPostRequest<UserInfoModel, string>(serverUrl, postData).Result;
            return userInfoModel;
        }

        public UserInfoModel Unfriend(string userId)
        {
            var serverUrl = "https://api.foursquare.com/v2/users/" + userId + "/unfriend";
            var userInfoModel = _httpClient.SendPostRequest<UserInfoModel, object>(serverUrl, null).Result;
            return userInfoModel;
        }

        public UserInfoModel UpdatProfilePhoto(string photo)
        {
            var serverUrl = "https://api.foursquare.com/v2/users/self/update";
            var argsDict = new UsersArgsDictionary(_accessToken).UpdatePhotoArgsDictionary(photo);
            string postData = QueryStringHelper.BuildPostData(argsDict);
            var userInfoModel = _httpClient.SendPostRequest<UserInfoModel, string>(serverUrl, postData).Result;
            return userInfoModel;
        }
        #endregion

        private bool IsAuthenticated()
        {
            return !string.IsNullOrEmpty(_accessToken);
        }
    }
}
