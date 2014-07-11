using FoursquareApi.Models.Common;
using FoursquareApi.Models.Common.User;

namespace FoursquareApi.Models.Users
{
    public class LeaderboardModel : FoursquareBaseModel<LeaderboardModelResponse>
    {}

    public class LeaderboardModelResponse
    {
        public FoursquareItemsEntity<LeaderboardItem> Leaderboard { get; set; } 
    }

    public class LeaderboardItem
    {
        public CompactUser User { get; set; }
        public Scores Scores { get; set; }
        public int Rank { get; set; }
    }
}
