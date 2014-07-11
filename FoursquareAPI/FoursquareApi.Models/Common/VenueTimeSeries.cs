using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApi.Models.Common
{
    public class VenueTimeSeries
    {
        public string VenueId { get; set; }
        public string Date { get; set; }
        public IEnumerable<int> TotalCheckins { get; set; }
        public IEnumerable<int> NewCheckins { get; set; }
        public IEnumerable<int> ShareTwitter { get; set; }
        public IEnumerable<int> ShareFacebook { get; set; }
        public IEnumerable<int> Male { get; set; }
        public IEnumerable<int> Female { get; set; }
        public IEnumerable<int> AgeXX_XX { get; set; }
    }
}
