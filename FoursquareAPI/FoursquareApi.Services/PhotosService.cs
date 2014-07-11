using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpClient;
using HttpClient.SerializationService;

namespace FoursquareApi.Services
{
    public class PhotosService :FoursquareApiService
    {
        public PhotosService(string clientId, string clientSecret, string accessToken)
        {
            Initialize(clientId, clientSecret, accessToken);
        }

        public void PhotoDetails(string photoId)
        {
            
        }

        public void AddPhoto(string checkinId = null,string tipId = null, string venueId = null, string pageId = null, string broadcast = null,bool? publicState = null, 
                                double? latitude = null, double? longitude = null,int? lAcc = null, int? alt = null, int? altAcc = null, string postUrl = null,string postContentId = null,
                                string postText = null)
        {
            
        }
    }
}
