using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common;
using FoursquareApi.Models.Common.Venue;

namespace FoursquareApi.Models.Venues
{
    public class SuggestCompletionVenuesModel : FoursquareBaseModel<SuggestCompletionVenuesResponse>
    {}

    public class SuggestCompletionVenuesResponse
    {
        public IEnumerable<MiniVenue> MiniVenues { get; set; }
    }
}
