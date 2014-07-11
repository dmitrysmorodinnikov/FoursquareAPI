using FoursquareApi.Models.Common.User;

namespace FoursquareApi.Models.Users
{
    public class UserInfoModel : FoursquareBaseModel<UserInfoResponse>
    {}

    public class UserInfoResponse
    {
        public CompleteUser User { get; set; }
    }
}
