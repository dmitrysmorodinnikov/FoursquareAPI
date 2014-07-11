using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common.Tip;
using FoursquareApi.Models.Common.User;
using FoursquareApi.Models.Common.Venue;

namespace FoursquareApi.Models.Common
{
    public class ListItem
    {
        public string Id { get; set; }
        public CompactUser User { get; set; }
        public Photo.Photo Photo { get; set; }
        public CompactVenue Venue { get; set; }
        public CompactTip Tip { get; set; }
        public string Note { get; set; }
        public long CreatedAt { get; set; }
        public IEnumerable<List> Listed { get; set; } 
    }
}
