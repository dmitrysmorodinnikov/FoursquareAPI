using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common;
using FoursquareApi.Models.Common.User;

namespace FoursquareApi.Models.Users
{
    public class FriendRequestsModel
    {
        public Meta Meta { get; set; }
        public FriendRequestsResponse Response { get; set; }
    }

    public class FriendRequestsResponse
    {
        public Requests Requests { get; set; }
    }

    public class Requests
    {
        public IEnumerable<CompactUser> Users { get; set; } 
    }
}
