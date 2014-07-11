using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApi.Models
{
    public class FoursquareItemsEntity<T>
    {
        public int Count { get; set; }
        public IEnumerable<T> Items { get; set; } 
    }
}
