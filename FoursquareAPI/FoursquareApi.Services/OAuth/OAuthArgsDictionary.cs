using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApi.Services.OAuth
{
    internal static class OAuthArgsDictionary
    {
        internal static Dictionary<string,string> AccessTokenArgsDictionary(string clientId,string clientSecret, string grantType,string redirectUri, string code)
        {
            return new Dictionary<string, string>()
            {
                { "client_id", clientId },
                { "client_secret", clientSecret },
                {"grant_type",grantType},
                {"redirect_uri",redirectUri},
                {"code",code}
            };
        }

        internal static Dictionary<string, string> AuthenticateArgsDictionary(string clientId, string responseType, string redirectUri)
        {
            return new Dictionary<string, string>()
            {
                { "client_id", clientId },
                { "response_type", responseType },
                {"redirect_uri",redirectUri}
            };
        }
    }
}
