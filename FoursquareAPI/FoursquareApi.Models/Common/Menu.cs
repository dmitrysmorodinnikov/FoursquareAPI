using System.Collections.Generic;

namespace FoursquareApi.Models.Common
{
    public class Menu
    {
        public string Name { get; set; }
        public string MenuId { get; set; }
        public string Description { get; set; }
        public FoursquareItemsEntity<Entry> Entries { get; set; }
    }
    
    public class Entry
    {
        public string Name { get; set; }
        public string SectionId { get; set; }
        public FoursquareItemsEntity<SubEntry> Entries { get; set; }
    }

    public class SubEntry
    {
        public string EntryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Prices { get; set; }
        public string Price { get; set; }
    }
}
