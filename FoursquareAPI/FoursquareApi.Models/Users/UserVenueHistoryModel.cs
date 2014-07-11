using FoursquareApi.Models.Common.Venue;

namespace FoursquareApi.Models.Users
{
    public class UserVenueHistoryModel : FoursquareBaseModel<UserVenueHistoryResponse>
    {}

    public class UserVenueHistoryResponse
    {
        public FoursquareItemsEntity<VenueItem> Venues { get; set; }
    }

    public class VenueItem
    {
        public int BeenHere { get; set; }
        public CompactVenue Venue { get; set; }
    }
}
