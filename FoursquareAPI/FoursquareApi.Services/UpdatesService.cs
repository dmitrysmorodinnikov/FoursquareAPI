using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpClient;
using HttpClient.SerializationService;

namespace FoursquareApi.Services
{
    public class UpdatesService : FoursquareApiService
    {
        public UpdatesService(string clientId, string clientSecret, string accessToken)
        {
            Initialize(clientId, clientSecret, accessToken);
        }

        public void UpdateDetail(string updateId)
        {
            
        }

        public void Notifications(short? limit = null)
        {
            
        }

        public void MarkNotificationsRead(long highWatermark)
        {
            
        }
    }
}
