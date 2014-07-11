using FoursquareApi.Models.Common.Venue;

namespace FoursquareApi.Models.Venues
{
    public class SimilarVenuesModel : FoursquareBaseModel<SimilarVenuesResponse>
    {}

    public class SimilarVenuesResponse
    {
        public FoursquareItemsEntity<CompleteVenue> SimilarVenues { get; set; } 
    }
}
