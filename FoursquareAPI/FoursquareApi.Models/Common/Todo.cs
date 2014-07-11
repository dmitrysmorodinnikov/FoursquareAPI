using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common.Tip;

namespace FoursquareApi.Models.Common
{
    public class Todo
    {
        public string Id { get; set; }
        public long CreatedAt { get; set; }
        public CompleteTip Tip { get; set; }
    }
}
