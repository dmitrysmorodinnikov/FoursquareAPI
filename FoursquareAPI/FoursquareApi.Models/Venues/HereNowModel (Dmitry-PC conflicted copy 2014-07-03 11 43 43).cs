using FoursquareApi.Models.Common.Checkin;

namespace FoursquareApi.Models.Venues
{
    public class HereNowModel : FoursquareBaseModel<HereNowResponse>
    {}

    public class HereNowResponse
    {
        public FoursquareItemsEntity<CompactCheckin> HereNow { get; set; }
    }
}
