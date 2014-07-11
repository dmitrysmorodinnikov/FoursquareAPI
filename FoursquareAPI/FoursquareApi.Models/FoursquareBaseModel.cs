using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common;

namespace FoursquareApi.Models
{
    public class FoursquareBaseModel<T>
    {
        public Meta Meta { get; set; }
        public T Response { get; set; }
    }
}
