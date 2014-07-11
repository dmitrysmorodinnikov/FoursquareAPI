using System.Collections.Generic;
using HttpClient;

namespace FoursquareApi.Services
{
    public static class ResultService 
    {
        public static T GetResult<T>(string serverUrl, Dictionary<string,string> argsDictionary, IHttpClient httpClient)
        {
            var queryString = QueryStringHelper.BuildQueryString(argsDictionary);
            var requestUrl = string.Concat(serverUrl, queryString);
            var result = httpClient.SendGetRequest<T>(requestUrl).Result;

            return result;
        }

        public static T PostResult<T>(string serverUrl, Dictionary<string, string> argsDictionary, IHttpClient httpClient)
        {
            var postData = QueryStringHelper.BuildPostData(argsDictionary);
            return httpClient.SendPostRequest<T, string>(serverUrl, postData).Result;
        }

        public static void PostResult(string serverUrl, Dictionary<string, string> argsDictionary, IHttpClient httpClient)
        {
            var postData = QueryStringHelper.BuildPostData(argsDictionary);
            httpClient.SendPostRequest<object, string>(serverUrl, postData);
        }
    }
}
