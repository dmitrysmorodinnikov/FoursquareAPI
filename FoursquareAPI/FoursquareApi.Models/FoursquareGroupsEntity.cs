using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApi.Models
{
    public class FoursquareGroupsEntity<T>
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public IEnumerable<T> Items { get; set; } 
    }
}
