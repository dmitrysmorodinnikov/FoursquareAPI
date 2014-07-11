using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common;

namespace FoursquareApi.Models.Venues
{
    public class VenuesCategoriesModel : FoursquareBaseModel<VenuesCategoriesResponse>
    {}

    public class VenuesCategoriesResponse
    {
        public IEnumerable<Category> Categories { get; set; }
    }
}
