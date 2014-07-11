using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApi.Models.Common
{
    public class Meta
    {
        public int Code { get; set; }
        //public IEnumerable<MetaNotification> MetaNotifications { get; set; } 
    }

    public class MetaNotification
    {
        public string Type { get; set; }
        public MetaNotificationItem Item { get; set; }
    }

    public class MetaNotificationItem
    {
        public int UnreadCount { get; set; }
    }
}
