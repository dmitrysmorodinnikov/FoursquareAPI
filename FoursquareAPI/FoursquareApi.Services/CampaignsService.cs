using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpClient;
using HttpClient.SerializationService;

namespace FoursquareApi.Services
{
    public class CampaignsService : FoursquareApiService
    {
        public CampaignsService(string clientId, string clientSecret, string accessToken)
        {
            Initialize(clientId, clientSecret, accessToken);
        }

        public void CampaignDetails(string campaignId)
        {
            
        }

        public void AddCampaign()
        {
            
        }
    }
}
