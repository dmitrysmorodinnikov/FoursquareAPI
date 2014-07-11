using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common;
using FoursquareApi.Models.Common.User;

namespace FoursquareApi.Models.Users
{
    public class UserInfoModel
    {
        public Meta Meta { get; set; }
        public UserInfoResponse Response { get; set; }
    }

    public class UserInfoResponse
    {
        public CompleteUser User { get; set; }
    }
}
