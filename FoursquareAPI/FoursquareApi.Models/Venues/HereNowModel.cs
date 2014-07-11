using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common;
using FoursquareApi.Models.Common.Checkin;

namespace FoursquareApi.Models.Venues
{
    public class HereNowModel : FoursquareBaseModel<HereNowResponse>
    {
    }

    public class HereNowResponse
    {
        public FoursquareItemsEntity<CompactCheckin> HereNow { get; set; }
    }
}
