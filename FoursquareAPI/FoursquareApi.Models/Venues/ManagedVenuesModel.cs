using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common;
using FoursquareApi.Models.Common.Venue;

namespace FoursquareApi.Models.Venues
{
    public class ManagedVenuesModel : FoursquareBaseModel<ManagedVenuesResponse>
    {
        //public Meta Meta { get; set; }
        //public ManagedVenuesResponse Response { get; set; }
    }

    public class ManagedVenuesResponse
    {
        public FoursquareItemsEntity<CompactVenue> Venues { get; set; }
    }

    //public class ManagedVenues
    //{
    //    public int Count { get; set; }
    //    public IEnumerable<CompactVenue> Items { get; set; } 
    //}
}
