using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpClient;
using Newtonsoft.Json;

namespace FoursquareApi.Models.Common.Venue
{
    public class CompleteVenue : CompactVenue
    {
        public string Description { get; set; }
        public int? CreatedAt { get; set; }
        public Mayor Mayor { get; set; }
        //tips
        //listed
       // public List<string> Tags { get; set; }
        public int? BeenHere { get; set; }
        public string ShotUrl { get; set; }
        public string CanonicalUrl { get; set; }
        public FoursquareItemsEntity<Special> Specials { get; set; } 
        //photos
        //likes
        public bool Like { get; set; }
        public bool Dislike { get; set; }
        //roles
        //flags
    }
}
