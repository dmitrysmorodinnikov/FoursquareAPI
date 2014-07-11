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
            var clientId = "XIZACSY31CPDOM43IYJJ4ZW50KY40CPZMRC0TXCELVAB0HAQ";
            var clientSecret = "B4ZUBS41PAI0FGODIKHXB01D2GXDP3YYCPB4TQ5TR23PDQO1";
            var redirectUri = "http://localhost:49517/Home/GetCode";
            var accessToken = "JQCKVWKGKDCDOGCWSJCNBFSMKHMDWG2BCACTRBXCYJEXQSBS";
            var foursquare = new Foursquare(clientId,clientSecret, redirectUri,accessToken);
            var result = foursquare.Users.FriendRequests();
        }
    }
}
