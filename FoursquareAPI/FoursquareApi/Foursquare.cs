using FoursquareApi.Services;
using FoursquareApi.Services.OAuth;

namespace FoursquareApi
{
    public class Foursquare
    {
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly string _redirectUri;
        private string _accessToken;
        

        public Foursquare(string clientId, string clientSecret)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
        }

        public Foursquare(string clientId, string clientSecret, string redirectUri)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            _redirectUri = redirectUri;
        }

        public Foursquare(string clientId, string clientSecret, string redirectUri, string accessToken)
        {
            _accessToken = accessToken;
            _clientId = clientId;
            _clientSecret = clientSecret;
            _redirectUri = redirectUri;
        }

        public VenuesService Venues{
            get
            {
                return new VenuesService(_clientId,_clientSecret,_accessToken);
            }
        }

        public UsersService Users
        {
            get
            {
                return new UsersService(_accessToken);
            }
        }

        //public VenueGroupsService VenueGroups
        //{
        //    get
        //    {
        //        return new VenueGroupsService(_clientId,_clientSecret,_accessToken);
        //    }
        //}

        //public CheckinsService Checkins
        //{
        //    get
        //    {
        //        return new CheckinsService(_clientId,_clientSecret,_accessToken);
        //    }
        //}

        //public TipsService Tips
        //{
        //    get
        //    {
        //        return new TipsService(_clientId,_clientSecret,_accessToken);
        //    }
        //}

        //public ListsService Lists
        //{
        //    get
        //    {
        //        return new ListsService(_clientId,_clientSecret,_accessToken);
        //    }
        //}

        //public UpdatesService Updates
        //{
        //    get
        //    {
        //        return new UpdatesService(_clientId,_clientSecret,_accessToken);
        //    }
        //}

        //public PhotosService Photos
        //{
        //    get
        //    {
        //        return new PhotosService(_clientId, _clientSecret, _accessToken);
        //    }
        //}

        //public SettingsService Settings
        //{
        //    get
        //    {
        //        return new SettingsService(_clientId, _clientSecret, _accessToken);
        //    }
        //}

        //public SpecialsService Specials
        //{
        //    get
        //    {
        //        return new SpecialsService(_clientId, _clientSecret, _accessToken);
        //    }
        //}

        //public CampaignsService Campaigns
        //{
        //    get
        //    {
        //        return new CampaignsService(_clientId, _clientSecret, _accessToken);
        //    }
        //}
        #region Authentication
        public void Authenticate()
        {
            new OAuthService(_clientId, _clientSecret, _redirectUri).Authenticate();
        }

        public string GetAccessToken(string code)
        {
            var accessToken = new OAuthService(_clientId, _clientSecret, _redirectUri).GetAccessToken(code);
            if(!string.IsNullOrEmpty(accessToken))
                SetAccessToken(accessToken);
            return accessToken;
        }

        private void SetAccessToken(string accessToken)
        {
            _accessToken = accessToken;
        }
        #endregion
    }
}
