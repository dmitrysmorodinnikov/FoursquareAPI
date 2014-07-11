using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common;

namespace FoursquareApi.Models.Venues
{
    public class VenueEventsModel : FoursquareBaseModel<VenueEventsResponse>
    {}

    public class VenueEventsResponse
    {
        public VenueEvents Events { get; set; }
    }

    public class VenueEvents : FoursquareItemsEntity<Event>
    {
        public string Summary { get; set; }
    }
}
