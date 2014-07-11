using System.Collections.Generic;
using FoursquareApi.Models.Common.Photo;

namespace FoursquareApi.Models.Common.User
{
    public class MiniUser
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Relationship { get; set; }
        public UserPhoto Photo { get; set; }
        public MiniUserFriends Friends { get; set; }
        public string Type { get; set; }
        public string Venue { get; set; }

    }

    public class MiniUserFriends
    {
        public int Count { get; set; }
        public IEnumerable<FriendGroup> Groups { get; set; } 
    }

    public class FriendGroup : FoursquareGroupsEntity<CompactUser>
    {
        public int Count { get; set; }
    }
}
