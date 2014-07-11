using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common.User;
using FoursquareApi.Models.Common.Venue;

namespace FoursquareApi.Models.Common.Checkin
{
    public class CompleteCheckin : CompactCheckin
    {
        public CompactUser User { get; set; }
        public CompactVenue Venue { get; set; }
        public Location Location { get; set; }
        public CheckinSource Source { get; set; }
        public CheckinEvent Event { get; set; }
        public FoursquareItemsEntity<Photo.Photo> Photos { get; set; }
        public Likes Likes { get; set; }
        public FoursquareItemsEntity<CompactCheckin> Overlaps { get; set; }
        public Score Score { get; set; }
        public bool Like { get; set; }
    }

    public class CheckinSource
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class CheckinEvent
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class CheckinPhotos : FoursquareItemsEntity<Photo.Photo>
    {}

    public class CheckinComments : FoursquareItemsEntity<CompactCheckin>
    {}

    public class Score
    {
        public int Count { get; set; }
        public Scores Scores { get; set; }
    }

    public class Likes
    {
        public int Count { get; set; }
        public IEnumerable<LikeGroup> Groups { get; set; }
        public string Summary { get; set; }
    }

    public class LikeGroup : FoursquareItemsEntity<LikeGroupItem>
    {
        public string Type { get; set; }
    }

    public class LikeGroupItem
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Relationship { get; set; }
        public Photo.Photo Photo { get; set; }
    }
}
