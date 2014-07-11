using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common.User;
using FoursquareApi.Models.Common.Venue;

namespace FoursquareApi.Models.Common.Tip
{
    public class CompactTip
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public long CreatedAt { get; set; }
        public Todo Status { get; set; }
        public string Url { get; set; }
        public Photo.Photo Photo { get; set; }
        public CompactUser User { get; set; }
        public CompactVenue Venue { get; set; }
    }
}
