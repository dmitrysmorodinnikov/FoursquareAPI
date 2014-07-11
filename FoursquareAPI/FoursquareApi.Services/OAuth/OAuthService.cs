using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using FoursquareApi.Models.OAuth;
using HttpClient;
using HttpClient.SerializationService;

namespace FoursquareApi.Services.OAuth
{
    public class OAuthService
    {
        private const string GetAccessTokenUrl = "https://foursquare.com/oauth2/access_token";
        private const string AuthenticateUrl = "https://foursquare.com/oauth2/authenticate";
        private readonly IHttpClient _httpClient;
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly string _redirectUri;

        public OAuthService(string clientId,string clientSecret,string redirectUri)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            _redirectUri = redirectUri;
            ISerializationService serializationService = new SerializationService();
            _httpClient = new HttpClient.HttpClient(serializationService);
        }

        public void Authenticate()
        {
            var argsDict = OAuthArgsDictionary.AuthenticateArgsDictionary(_clientId, "code", _redirectUri);
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(AuthenticateUrl, queryString);
            _httpClient.SendGetRequest<object>(requestUrl);
        }

        public string GetAccessToken(string code)
        {
            var argsDict = OAuthArgsDictionary.AccessTokenArgsDictionary(_clientId,_clientSecret,"authorization_code", _redirectUri,code);
            var queryString = QueryStringHelper.BuildQueryString(argsDict);
            var requestUrl = string.Concat(GetAccessTokenUrl, queryString);
            var accessToken = _httpClient.SendGetRequest<AccessTokenModel>(requestUrl).Result.Access_Token;
            return accessToken;
        }
    }
}
