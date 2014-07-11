using FoursquareApi.Models.Common;

namespace FoursquareApi.Models.Venues
{
    public class VenueMenuModel : FoursquareBaseModel<VenueMenuResponse>
    {}

    public class VenueMenuResponse
    {
        public VenueMenu Menu { get; set; }
    }

    public class VenueMenu
    {
        public MenuProvider Provider { get; set; }
        public FoursquareItemsEntity<Menu> Menus { get; set; }
    }

    public class MenuProvider
    {
        public string Name { get; set; }
        public string AttributionImage { get; set; }
        public string AttributionLink { get; set; }
        public string AttributionText { get; set; }
    }
}
