using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common.Checkin;

namespace FoursquareApi.Models.Common
{
    public class HereNow
    {
        public int Count { get; set; }
        public IEnumerable<CompactCheckin> Checkins { get; set; } 
    }
}
