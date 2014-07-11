using FoursquareApi.Models.Common.Photo;

namespace FoursquareApi.Models.Users
{
    public class UserPhotosModel : FoursquareBaseModel<UserPhotosResponse>
    {}

    public class UserPhotosResponse
    {
        public FoursquareItemsEntity<Photo> Photos { get; set; }
    }
}
