using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using HttpClient;
using HttpClient.SerializationService;

namespace FoursquareApi.Services
{
    public class SpecialsService : FoursquareApiService
    {

        public SpecialsService(string clientId, string clientSecret, string accessToken)
        {
            Initialize(clientId, clientSecret, accessToken);
        }

        public void SpecialDetail(string specialId, string venueId,string userId = null)
        {
            
        }

        public void AddSpecial(string text, string unlockedText, string type, string name = null,string finePrint = null, int? count1 = null, string offerId = null, double? cost = null)
        {
            
        }

        public void SpecialsList(string venueId = null, string status = null)
        {
            
        }

        public void Search(double latitude, double longitude, int? radius = null, double? llAcc = null, double? alt = null, double? altAcc = null, short? limit = null)
        {
            
        }

        public void Configuration(string specialId)
        {
            
        }

        public void FlagSpecial(string id,string venueId,string problem,string text = null)
        {
            
        }

        public void RetireSpecial(string specialId)
        {
            
        }
    }
}
