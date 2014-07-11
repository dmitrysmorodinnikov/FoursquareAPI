using System.Collections.Generic;

namespace FoursquareApi.Models.Common.Hour
{
    public class FormattedHour
    {
        public string Status { get; set; }
        public bool IsOpen { get; set; }
        public IEnumerable<Timeframe> Timeframes { get; set; } 
    }

    public class Timeframe
    {
        public string Days { get; set; }
        public bool IncludesToday { get; set; }
        public IEnumerable<Open> Open { get; set; }
        public IEnumerable<FormattedHourSegment> Segments { get; set; } 
    }

    public class FormattedHourSegment
    {
        public string Label { get; set; }
        public string RenderedTime { get; set; }
    }

    public class Open
    {
        public string RenderedTime { get; set; }
    }
}
