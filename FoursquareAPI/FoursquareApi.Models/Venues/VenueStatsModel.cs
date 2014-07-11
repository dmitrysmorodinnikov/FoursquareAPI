using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common;

namespace FoursquareApi.Models.Venues
{
    public class VenueStatsModel : FoursquareBaseModel<VenueStatsResponse>
    {}

    public class VenueStatsResponse
    {
        public VenueStats Stats { get; set; }
    }
}
