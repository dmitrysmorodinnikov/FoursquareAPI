using FoursquareApi;

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
            var foursquare = new Foursquare(clientId, clientSecret, redirectUri,accessToken);
            
            

            var venueDetail = foursquare.Venues.VenueDetail("4c263af6a852c9287537e66c");
            var trendingVenues = foursquare.Venues.TrendingVenues(40.7,-74);
            var userDetail = foursquare.Users.User("userId");
            var userPhotos = foursquare.Users.UserPhotos("userId");
        }
    }
}
