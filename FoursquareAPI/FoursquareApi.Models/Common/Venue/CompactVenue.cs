using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common.Hour;

namespace FoursquareApi.Models.Common.Venue
{
    public class CompactVenue : MiniVenue
    {
        public Contact Contact { get; set; }
        public bool Verified { get; set; }
        public Stats Stats { get; set; }
        public string Url { get; set; }
       // public FormattedHour Hours { get; set; } in later version
        //popular: in later version
        public VenueMenu Menu { get; set; }
        public Price Price { get; set; }
        public short Rating { get; set; }
        //hereNow
        public string StoreId { get; set; }
        //page
    }

    public class VenueMenu
    {
        public string Type { get; set; }
        public string Label { get; set; }
        public string Anchor { get; set; }
        public string Url { get; set; }
        public string MobileUrl { get; set; }
    }
}
