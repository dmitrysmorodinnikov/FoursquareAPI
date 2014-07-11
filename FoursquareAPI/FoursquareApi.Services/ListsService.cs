using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using HttpClient;
using HttpClient.SerializationService;

namespace FoursquareApi.Services
{
    public class ListsService : FoursquareApiService
    {
        public ListsService(string clientId, string clientSecret, string accessToken)
        {
            Initialize(clientId, clientSecret, accessToken);
        }

        public void ListDetail(string listId, short? limit = null, int? offset = null,string llBounds = null, string sort = null)
        {
            
        }

        public void AddList(string name,string description = null, bool? collaborative = null, string photoId = null)
        {
            
        }

        #region Aspects

        public void ListFollowers(string listId)
        {
            
        }

        public void ListSaves(string listId)
        {
            
        }

        public void SuggestPhoto(string listId,string itemId)
        {
            
        }

        public void SuggestTip(string listId, string itemId)
        {
            
        }

        public void SuggestVenues(string listId)
        {
            
        }
        #endregion

        #region Actions

        public void AddItem(string listId, string venueId = null,string text = null, string url = null)
        {
            
        }

        public void DeleteItem(string listId, string itemId = null, string venueId = null, string tipId = null)
        {
            
        }

        public void FollowList(string listId)
        {
            
        }

        public void MoveItem(string listId,string itemId,string beforeId = null,string afterId = null)
        {
            
        }

        public void Share(string listId,string broadcast = null,string message = null)
        {
            
        }

        public void Unfollow(string listId)
        {
            
        }

        public void Update(string listId, string name = null, string description = null, bool? collaborative = null, string photoId = null)
        {
            
        }

        public void UpdateItem(string listId, string itemId, string text = null, string url = null,string photoId = null)
        {
            
        }
        #endregion
    }
}
