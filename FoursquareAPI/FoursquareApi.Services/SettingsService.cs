using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpClient;
using HttpClient.SerializationService;

namespace FoursquareApi.Services
{
    public class SettingsService : FoursquareApiService
    {
        public SettingsService(string clientId, string clientSecret, string accessToken)
        {
            Initialize(clientId, clientSecret, accessToken);
        }

        public void SettingDetail(string settingId)
        {
            
        }

        public void AllSettings()
        {
            
        }

        public void Set(string settingId, bool value)
        {
            
        }
    }
}
