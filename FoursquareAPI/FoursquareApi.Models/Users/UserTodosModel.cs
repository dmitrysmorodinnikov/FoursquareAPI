using FoursquareApi.Models.Common;

namespace FoursquareApi.Models.Users
{
    public class UserTodosModel : FoursquareBaseModel<UserTodoResponse>
    {}

    public class UserTodoResponse
    {
        public FoursquareItemsEntity<Todo> Todos { get; set; }
    }
}
