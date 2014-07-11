using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common.User;

namespace FoursquareApi.Models.Common
{
    public class Comment
    {
        public string Id { get; set; }
        public long CreatedAt { get; set; }
        public CompactUser User { get; set; }
        public string Text { get; set; }
    }
}
