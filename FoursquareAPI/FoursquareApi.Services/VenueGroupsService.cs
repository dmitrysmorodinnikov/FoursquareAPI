using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpClient;
using HttpClient.SerializationService;

namespace FoursquareApi.Services
{
    public class VenueGroupsService : FoursquareApiService
    {
        public VenueGroupsService(string clientId, string clientSecret, string accessToken)
        {
            Initialize(clientId, clientSecret, accessToken);
        }

        public void VenueGroupDetails(string groupId)
        {
            
        }

        public void AddVenueGroup(string name, string venueId = null)
        {
            
        }

        public void DeleteVenueGroup(string groupId)
        {
            
        }

        public void ListVenueGroups()
        {

        }

        #region Aspects

        public void VenueGroupTimeseries(string groupId,long startAt,long? endAt,string fields = null)
        {
            
        }

        #endregion

        #region Actions

        public void AddVenueToGroup(string groupId,string venueId)
        {
            
        }

        public void VenueGroupCampaigns(string groupId)
        {
            
        }

        public void EditVenuesInVenueGroup(string venueGroupId, string name = null, string city = null,string state = null, string zip = null, string phone = null,string categoryId = null,
                                            string twitter = null,string description = null,string url = null,string hours = null)
        {
            
        }

        public void RemoveVenueFromVenueGroup(string groupId,string venueId)
        {
            
        }

        public void UpdateVenueGroup(string groupId, string name = null, string venueId = null)
        {
            
        }
        #endregion
    }
}
