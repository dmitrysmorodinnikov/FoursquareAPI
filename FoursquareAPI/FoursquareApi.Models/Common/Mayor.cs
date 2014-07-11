using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common.User;

namespace FoursquareApi.Models.Common
{
    public class Mayor
    {
        public CompactUser User { get; set; }
        public int Count { get; set; }
    }
}
