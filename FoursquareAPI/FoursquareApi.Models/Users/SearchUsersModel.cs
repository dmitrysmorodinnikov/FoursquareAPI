using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common;
using FoursquareApi.Models.Common.User;

namespace FoursquareApi.Models.Users
{
    public class SearchUsersModel : FoursquareBaseModel<SearchUsersResponse>
    {}

    public class SearchUsersResponse
    {
        public IEnumerable<CompactUser> Results { get; set; }
        //Unmatched???
    }
}
