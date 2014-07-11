using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common;

namespace FoursquareApi.Models.Venues
{
    public class VenueTimeSeriesModel : FoursquareBaseModel<VenueTimeSeriesResponse>
    {
        //public Meta Meta { get; set; }
        //public VenueTimeSeriesResponse Response { get; set; }
    }

    public class VenueTimeSeriesResponse
    {
        public IEnumerable<VenueTimeSeries> Timeseries { get; set; }
    }


}
