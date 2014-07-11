using FoursquareApi.Models.Common.Venue;

namespace FoursquareApi.Models.Venues
{
    public class NextVenuesModel : FoursquareBaseModel<NextVenuesResponse>
    {}

    public class NextVenuesResponse
    {
        public FoursquareItemsEntity<CompactVenue> NextVenues { get; set; }
    }
}
