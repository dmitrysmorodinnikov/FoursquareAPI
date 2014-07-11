using System.Collections.Generic;
using FoursquareApi.Models.Common;

namespace FoursquareApi.Models.Users
{
    public class UserBadgesModel : FoursquareBaseModel<UserBadgesResponse>
    {}

    public class UserBadgesResponse
    {
        public Sets Sets { get; set; }
        public IEnumerable<KeyValuePair<string,Badge>> Badges { get; set; } 
    }

    public class Sets
    {
        public IEnumerable<SetGroup> Groups { get; set; } 
    }

    public class SetGroup
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public Image Image { get; set; }
        public IEnumerable<string> Items { get; set; }
        //groups??
    }
}
