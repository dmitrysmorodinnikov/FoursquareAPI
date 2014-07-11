using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApi.Models.Common.Venue
{
    public class MiniVenue
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Location Location { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
