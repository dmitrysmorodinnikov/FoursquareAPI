using FoursquareApi.Models.Common.Checkin;

namespace FoursquareApi.Models.Users
{
    public class UserCheckinsModel : FoursquareBaseModel<UserCheckinsResponse>
    {}

    public class UserCheckinsResponse
    {
        public FoursquareItemsEntity<CompleteCheckin> Checkins { get; set; }
    }
}
