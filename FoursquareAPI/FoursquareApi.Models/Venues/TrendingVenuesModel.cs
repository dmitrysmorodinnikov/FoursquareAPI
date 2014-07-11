using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common;
using FoursquareApi.Models.Common.Venue;

namespace FoursquareApi.Models.Venues
{
    public class TrendingVenuesModel : FoursquareBaseModel<TrendingVenuesResponse>
    {
        //public Meta Meta { get; set; }
        //public TrendingVenuesResponse Response { get; set; }
    }

    public class TrendingVenuesResponse
    {
        public IEnumerable<CompactVenue> Venues { get; set; }
    }
}
