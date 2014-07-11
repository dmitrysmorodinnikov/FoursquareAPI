using System.Collections.Generic;
using FoursquareApi.Models.Common;

namespace FoursquareApi.Models.Venues
{
    public class VenueListsModel : FoursquareBaseModel<VenueListsResponse>
    {}

    public class VenueListsResponse
    {
        public Lists Lists { get; set; }
    }

    public class Lists : FoursquareItemsEntity<List>
    {
        public IEnumerable<ListGroup> Groups { get; set; } 
    }

    public class ListGroup : FoursquareGroupsEntity<List>
    {
       public int Count { get; set; }
    }
}
