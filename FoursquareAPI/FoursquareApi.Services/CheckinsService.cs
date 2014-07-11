using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpClient;
using HttpClient.SerializationService;

namespace FoursquareApi.Services
{
    public class CheckinsService : FoursquareApiService
    {
        public CheckinsService(string clientId, string clientSecret, string accessToken)
        {
            Initialize(clientId, clientSecret, accessToken);
        }

        public void CheckinDetails(string checkinId, string signature = null)
        {
            
        }

        public void AddCheckin(string venueId,string eventId = null, string shout = null, string mentions = null,string broadcast = null, double? latitude = null,double? longitude = null, int? llAcc = null,
                                int? alt = null, int? altAcc = null)
        {
            
        }

        public void RecentCheckinsFromFriends(double? latitude = null,double? longitude = null, short? limit = null, long? afterTimestamp = null)
        {

        }

        #region Aspects

        public void CheckinLikes(string checkinId)
        {
            
        }

        #endregion

        #region Actions

        public void AddCommentToCheckin(string checkinId,string text = null, string mentions = null)
        {
            
        }

        public void AddPost(string checkinId, string text = null, string url = null, string contentId = null)
        {
            
        }

        public void DeleteCommentFromCheckin(string checkinId, string commentId)
        {
            
        }

        public void LikeCheckin(string checkinId, bool? set = null)
        {
            
        }
        #endregion
    }
}
