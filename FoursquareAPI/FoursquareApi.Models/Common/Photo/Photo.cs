using FoursquareApi.Models.Common.Checkin;
using FoursquareApi.Models.Common.Tip;
using FoursquareApi.Models.Common.User;
using FoursquareApi.Models.Common.Venue;

namespace FoursquareApi.Models.Common.Photo
{
    public class Photo
    {
        public string Id { get; set; }
        public int? CreatedAt { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string Visibility { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public PhotoSource Source { get; set; }
        public CompactUser User { get; set; }
        public CompactVenue Venue { get; set; }
        public CompactTip Tip { get; set; }
        public CompactCheckin Checkin { get; set; }
    }

    public class PhotoSource
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
