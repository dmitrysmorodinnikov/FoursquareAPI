using System.Collections.Generic;
using FoursquareApi.Models.Common.Checkin;

namespace FoursquareApi.Models.Common.User
{
    public class CompleteUser : MiniUser
    {
        public string HomeCity { get; set; }
        public string Gender { get; set; }
        public Contact Contact { get; set; }
        public string Bio { get; set; }
        public FoursquareItemsEntity<Tip.CompactTip> Tips { get; set; }
        public CompleteUserLists Lists { get; set; }
        //followers:in later version
        public Following Following { get; set; }
        public FoursquareItemsEntity<Badge> Badges { get; set; }
        public Mayorships Mayorships { get; set; }
        public FoursquareItemsEntity<Photo.Photo> Photos { get; set; }
        public Scores Scores { get; set; }
        public FoursquareItemsEntity<CompleteCheckin> Checkins { get; set; } 
        //pageInfo : in later version
        public string Pings { get; set; }
        //public int Requests { get; set; } : in later version
    }

    public class CompleteUserLists
    {
        public int Count { get; set; }
        public IEnumerable<CompleteUserListsGroup> Groups { get; set; } 
    }

    public class CompleteUserListsGroup
    {
        public string Type { get; set; }
        public int Count { get; set; }
        public IEnumerable<List> Items { get; set; } 
    }

    public class Following
    {
        public int Count { get; set; }
        public IEnumerable<FollowingGroup> Groups { get; set; } 
    }

    public class FollowingGroup : FoursquareGroupsEntity<CompactUser>
    {
        public int Count { get; set; }
    }

    public class Mayorships
    {
        public int Count { get; set; }
    }
}
