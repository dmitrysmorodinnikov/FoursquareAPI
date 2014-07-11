using System.Collections.Generic;

namespace FoursquareApi.Models.Common
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PluralName { get; set; }
        public string ShortName { get; set; }
        public Icon Icon { get; set; }
        public bool Primary { get; set; }
        public IEnumerable<Category> Categories { get; set; } 
    }

    public class Icon
    {
        public string Prefix { get; set; }
        public string Suffix { get; set; }
    }
}
