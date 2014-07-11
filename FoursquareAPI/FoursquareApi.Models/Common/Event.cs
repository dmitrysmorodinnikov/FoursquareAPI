using System.Collections.Generic;
using FoursquareApi.Models.Common.Checkin;

namespace FoursquareApi.Models.Common
{
    public class Event
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Url { get; set; }
        public FoursquareItemsEntity<ForeignIdsItem> ForeignIds { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public EventHereNow HereNow { get; set; }
        public Stats Stats { get; set; }
        public long? startAt { get; set; }
        public long? endAt { get; set; }
        public bool? allDay { get; set; }
        public long? Date { get; set; }
    }

    public class ForeignIdsItem
    {
        public string Id { get; set; }
        public string Domain { get; set; }
    }

    public class EventHereNow
    {
        public int Count { get; set; }
        public IEnumerable<HereNowGroup> Groups { get; set; }
    }

    public class HereNowGroup : FoursquareGroupsEntity<CompactCheckin>
    {
        public int Count { get; set; }
    }
}
