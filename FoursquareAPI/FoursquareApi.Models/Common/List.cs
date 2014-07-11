using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common.User;

namespace FoursquareApi.Models.Common
{
    public class List
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public CompactUser User { get; set; }
        public bool? Following { get; set; }
        public Followers Followers { get; set; }
        public bool? Editable { get; set; }
        public bool Public { get; set; }
        public bool Collaborative { get; set; }
        public string Url { get; set; }
        public Collaborators Collaborators { get; set; }
        public string CanonicalUrl { get; set; }
        public Photo.Photo Photo { get; set; }
        public long CreatedAt { get; set; }
        public long UpdatedAt { get; set; }
        public bool LogView { get; set; }
        public int VenueCount { get; set; }
        public int VisitedCount { get; set; }
        public ListItems ListItems { get; set; }
    }

    public class Followers
    {
        public int Count { get; set; }
        public IEnumerable<CompactUser> Items { get; set; } 
    }

    public class Collaborators : Followers
    {
        
    }

    public class ListItems
    {
        public int Count { get; set; }
        public IEnumerable<ListItem> Items { get; set; } 
    }
}
