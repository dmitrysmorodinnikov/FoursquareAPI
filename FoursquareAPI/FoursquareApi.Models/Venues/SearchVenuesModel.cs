using System.Collections.Generic;
using FoursquareApi.Models.Common;
using FoursquareApi.Models.Common.Venue;

namespace FoursquareApi.Models.Venues
{
    public class SearchVenuesModel : FoursquareBaseModel<SearchVenuesResponse>
    {
        // public SearchVenuesResponse Response { get; set; }
    }
    public class SearchVenuesResponse
    {
        public IEnumerable<CompactVenue> Venues { get; set; }
    }
}