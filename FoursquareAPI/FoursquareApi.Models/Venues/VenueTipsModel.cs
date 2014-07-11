using FoursquareApi.Models.Common.Tip;

namespace FoursquareApi.Models.Venues
{
    public class VenueTipsModel : FoursquareBaseModel<VenueTipsResponse>
    {}

    public class VenueTipsResponse
    {
        public FoursquareItemsEntity<CompleteTip> Tips { get; set; }
    }
}
