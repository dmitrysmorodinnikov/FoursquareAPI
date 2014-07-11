using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApi.Models.Common
{
    public class Scores
    {
        public long Recent { get; set; }
        public long Max { get; set; }
        public long Goal { get; set; }
        public int CheckinsCount { get; set; }
    }
}
