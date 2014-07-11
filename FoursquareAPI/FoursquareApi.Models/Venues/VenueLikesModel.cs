using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common;
using FoursquareApi.Models.Common.Checkin;

namespace FoursquareApi.Models.Venues
{
    public class VenueLikesModel : FoursquareBaseModel<VenueLikesResponse>
    {}

    public class VenueLikesResponse
    {
        public VenueLikes Likes { get; set; }
        public bool Like { get; set; }
    }

    public class VenueLikes : FoursquareItemsEntity<LikeGroupItem>
    {
       public string Summary { get; set; }
    }
}
