using System.Collections.Generic;
using FoursquareApi.Models.Common;

namespace FoursquareApi.Models.Users
{
    public class UserListsModel : FoursquareBaseModel<UserListsResponse>
    {}

    public class UserListsResponse
    {
        public Lists Lists { get; set; }
    }
     
    public class Lists : FoursquareItemsEntity<List>
    {
        public IEnumerable<UserListsGroup> Groups { get; set; }
    }

    public class UserListsGroup : FoursquareGroupsEntity<List>
    {
        public int Count { get; set; }
    }
}
