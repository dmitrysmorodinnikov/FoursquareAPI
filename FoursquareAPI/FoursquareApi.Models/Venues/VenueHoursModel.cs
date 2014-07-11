using System.Collections.Generic;
using FoursquareApi.Models.Common.Hour;

namespace FoursquareApi.Models.Venues
{
    public class VenueHoursModel : FoursquareBaseModel<VenueHoursResponse>
    {}

    public class VenueHoursResponse
    {
        public TimeframeClass Hours { get; set; } 
        public TimeframeClass Popular { get; set; }
    }

    public class TimeframeClass
    {
        public IEnumerable<Hour> Timeframes { get; set; }
    }
}
