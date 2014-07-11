using FoursquareApi.Models.Common;
using FoursquareApi.Models.Common.Photo;

namespace FoursquareApi.Models.Venues
{
    public class VenuePhotosModel : FoursquareBaseModel<VenuePhotosResponse>
    {}

    public class VenuePhotosResponse
    {
        public FoursquareItemsEntity<Photo> Photos { get; set; } 
    }
}
