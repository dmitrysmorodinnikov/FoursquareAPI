using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpClient;
using HttpClient.SerializationService;

namespace FoursquareApi.Services
{
    public class TipsService : FoursquareApiService
    {
        public TipsService(string clientId, string clientSecret, string accessToken)
        {
            Initialize(clientId, clientSecret, accessToken);
        }

        public void TipDetail(string tipId)
        {

        }

        public void AddTip(string venueId, string text,string url = null, string broadcast = null)
        {
            
        }

        public void SearchTips(double latitude,double longitude, short? limit = null, int? offset = null,string filter = null,string query = null)
        {
            
        }

        #region Aspects

        public void TipLikes(string tipId)
        {
            
        }

        public void TipLists(string tipId, string group = null)
        {
            
        }

        public void TipSaves(string tipId)
        {
            
        }
        
        #endregion

        #region Actions

        public void FlagTip(string tipId, string problem, string comment = null)
        {
            
        }

        public void LikeTip(string tipId,bool? set = null)
        {
            
        }

        public void UnmarkTipFromTodoList(string tipId)
        {
            
        }
        #endregion
    }
}
