using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApi.Models.Common.User
{
    public class CompactUser : MiniUser
    {
        public string HomeCity { get; set; }
        public string Gender { get; set; }
        public Contact Contact { get; set; }
        public string Bio { get; set; }
        public CompactUserTips Tips { get; set; }
        public CompactUserLists Lists { get; set; }
        //followers:in later version
    }

    public class CompactUserTips
    {
        public int Count { get; set; }
    }

    public class CompactUserLists
    {
        public IEnumerable<CompactUserListsGroup> Groups { get; set; } 
    }

    public class CompactUserListsGroup
    {
        public string Type { get; set; }
        public int Count { get; set; }
    }
}
