using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApi.Models.Common
{
    public class Image
    {
        public string Prefix { get; set; }
        public IEnumerable<int> Sizes { get; set; }
        public string Name { get; set; }
    }
}
