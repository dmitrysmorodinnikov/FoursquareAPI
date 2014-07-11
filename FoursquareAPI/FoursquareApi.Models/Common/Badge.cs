using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApi.Models.Common
{
    public class Badge
    {
        public string Id { get; set; }
        public string BadgeId { get; set; }
        public string Name { get; set; }
        public string UnlockMessage { get; set; }
        public string Description { get; set; }
        public string BadgeText { get; set; }
        public Image Image { get; set; }
        public IEnumerable<Unlock> Unlocks { get; set; } 
    }

    public class Unlock
    {
        public IEnumerable<Checkin.CompleteCheckin> Checkins { get; set; }
    }
}
