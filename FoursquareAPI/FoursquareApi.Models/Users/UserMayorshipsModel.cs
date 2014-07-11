using FoursquareApi.Models.Common.Venue;

namespace FoursquareApi.Models.Users
{
    public class UserMayorshipsModel : FoursquareBaseModel<UserMayorshipsResponse>
    {}

    public class UserMayorshipsResponse
    {
        public FoursquareItemsEntity<CompactVenue> Mayorships { get; set; }
    }
}
