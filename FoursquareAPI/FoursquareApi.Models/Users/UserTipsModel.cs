using FoursquareApi.Models.Common.Tip;

namespace FoursquareApi.Models.Users
{
    public class UserTipsModel : FoursquareBaseModel<UserTipsResponse>
    {}

    public class UserTipsResponse
    {
        public FoursquareItemsEntity<CompleteTip> Tips { get; set; }
    }
}
