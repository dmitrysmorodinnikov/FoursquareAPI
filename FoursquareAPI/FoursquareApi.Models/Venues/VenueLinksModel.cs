using FoursquareApi.Models.Common;

namespace FoursquareApi.Models.Venues
{
    public class VenueLinksModel : FoursquareBaseModel<VenueLinksResponse>
    {}

    public class VenueLinksResponse
    {
        public FoursquareItemsEntity<Link> Links { get; set; }
    }
}
