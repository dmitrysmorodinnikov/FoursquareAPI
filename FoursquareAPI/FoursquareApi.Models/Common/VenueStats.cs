using System.Collections.Generic;
using FoursquareApi.Models.Common.User;

namespace FoursquareApi.Models.Common
{
    public class VenueStats
    {
        public int TotalCheckins { get; set; }
        public int NewCheckins { get; set; }
        public int UniqueVisitors { get; set; }
        public Sharing Sharing { get; set; }
        public GenderBreakdown GenderBreakdown { get; set; }
        public IEnumerable<AgeBreakdownItem> AgeBreakdown { get; set; }
        public IEnumerable<HourBreakdownItem> HourBreakdown { get; set; }
        public IEnumerable<VisitCountHistogramItem> VisitCountHistogram { get; set; }
        public IEnumerable<TopVisitor> TopVisitors { get; set; }
        public IEnumerable<RecentVisitor> RecentVisitors { get; set; } 
    }

    public class Sharing
    {
        public int Twitter { get; set; }
        public int Facebook { get; set; }
    }

    public class GenderBreakdown
    {
        public int Female { get; set; }
        public int Male { get; set; }
    }

    public class AgeBreakdownItem
    {
        public string Age { get; set; }
        public int Checkins { get; set; }
    }

    public class HourBreakdownItem
    {
        public int Hour { get; set; }
        public int Checkins { get; set; }
    }

    public class VisitCountHistogramItem
    {
        public int Checkins { get; set; }
        public int Users { get; set; }
    }

    public class TopVisitor
    {
        public CompactUser User { get; set; }
        public int Checkins { get; set; }
    }

    public class RecentVisitor
    {
        public CompactUser User { get; set; }
        public long? LastCheckin { get; set; }
    }
}
