using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi;
using FoursquareApi.Models.Users;

namespace SamplesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientId = "Your_clientId";
            var clientSecret = "Your_clientSecret";
            var redirectUri = "Your_RedirectUri";
            var accessToken = "Your_accessToken";
            var foursquare = new Foursquare(clientId,clientSecret, redirectUri,accessToken);
            var result = foursquare.Venues.TrendingVenues(40.7,-74);
        }
    }
}
