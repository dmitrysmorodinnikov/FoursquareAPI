using FoursquareApi.Models.Common.User;

namespace FoursquareApi.Models.Venues
{
    public class UserFriendsModel : FoursquareBaseModel<UserFriendsResponse>
    {}

    public class UserFriendsResponse 
    {
        public FoursquareItemsEntity<CompactUser> Friends { get; set; }
    }
}
