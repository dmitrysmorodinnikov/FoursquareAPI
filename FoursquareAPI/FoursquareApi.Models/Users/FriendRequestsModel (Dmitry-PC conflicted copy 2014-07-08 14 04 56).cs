using System.Collections.Generic;
using FoursquareApi.Models.Common.User;

namespace FoursquareApi.Models.Users
{
    public class FriendRequestsModel : FoursquareBaseModel<FriendRequestsResponse>
    {}

    public class FriendRequestsResponse
    {
        public IEnumerable<CompactUser> Requests { get; set; }
    }
}
