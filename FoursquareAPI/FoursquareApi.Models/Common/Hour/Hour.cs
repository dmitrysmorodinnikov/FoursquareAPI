using System.Collections.Generic;

namespace FoursquareApi.Models.Common.Hour
{
    public class Hour
    {
        public IEnumerable<int> Days { get; set; }
        public IEnumerable<OpenClass> Open { get; set; }
        public bool IncludesToday { get; set; }
        public IEnumerable<Segment> Segments { get; set; } 
    }

    public class OpenClass
    {
        public string Start { get; set; }
        public string End { get; set; }
    }

    public class Segment
    {
        public string Label { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
    }
}
