using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common;
using FoursquareApi.Models.Common.User;
using FoursquareApi.Models.Common.Venue;

namespace FoursquareApi.Models.Venues
{
    public class ExploreVenuesModel : FoursquareBaseModel<ExploreVenuesResponse>
    {}

    public class ExploreVenuesResponse
    {
        //keywords?
        public int? SuggestedRadius { get; set; }
        public Warning Warning { get; set; }
        public string HeaderLocation { get; set; }
        public string HeaderLocationGranularity { get; set; }
        public int TotalResults { get; set; }
        public string HeaderFullLocation { get; set; }
        public string HeaderMessage { get; set; }
        public IEnumerable<FoursquareGroupsEntity<Item>> Groups { get; set; }
        public SuggestedFilters SuggestedFilters { get; set; }
        public SuggestedBounds SuggestedBounds { get; set; }
    }

    public class SuggestedBounds
    {
        public Ne Ne { get; set; }
        public Sw Sw { get; set; }
    }

    public class Ne
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
    }

    public class Sw
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
    }

    public class SuggestedFilters
    {
        public string Header { get; set; }
        public IEnumerable<Filter> Filters { get; set; }
    }

    public class Filter
    {
        public string Name { get; set; }
        public string Key { get; set; }
    }

    public class Warning
    {
        public string Text { get; set; }
    }

    public class Item
    {
        public FoursquareItemsEntity<ReasonItem> Reasons { get; set; }
        public FoursquareItemsEntity<SnippetItem> Snippets { get; set; }
        public CompactVenue Venue { get; set; }
    }

    public class ReasonItem
    {
        public string Summary { get; set; }
        public string Type { get; set; }
        public string ReasonName { get; set; }
        public string Message { get; set; }
        public int Count { get; set; }
    }

    public class SnippetItem
    {
        public SnippetReason Reason { get; set; }
    }

    public class SnippetReason
    {
        public string Text { get; set; }
        public FoursquareItemsEntity<FacepileItem> Facepile { get; set; }
    }

    public class FacepileItem
    {
        public int VisitedCount { get; set; }
        public bool Liked { get; set; }
        public bool Disliked { get; set; }
        public int Photos { get; set; }
        public MiniUser User { get; set; }
    }
}
