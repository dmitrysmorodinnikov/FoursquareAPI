using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApi.Models.Common.Checkin
{
    public class CompactCheckin
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public int TimeZoneOffset { get; set; }
        public long CreatedAt { get; set; }
        public string Private { get; set; }
        public string Shout { get; set; }
    }
}
