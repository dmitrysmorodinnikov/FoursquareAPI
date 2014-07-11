using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common.User;
using FoursquareApi.Models.Users;
using HttpClient;
using HttpClient.SerializationService;

namespace FoursquareApi.Services.Users
{
    public class UserInfoService
    {
        private const string ServerUrl = "https://api.foursquare.com/v2/users/USER_ID";
        private readonly IHttpClient _httpClient;
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly string _redirectUri;
        public UserInfoService()
        {
            ISerializationService serializationService = new SerializationService();
            _httpClient = new HttpClient.HttpClient(serializationService);
        }
        public UserInfoModel User(string userId,string accessToken)
        {
            var argsDict = UsersArgsDictionary.UserInfoArgsDictionary(accessToken);
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(ServerUrl, queryString);
            var userInfoModel = _httpClient.SendGetRequest<UserInfoModel>(requestUrl).Result;
            return userInfoModel;
        }
    }
}
