using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoursquareApi.Models.Common.User;

namespace FoursquareApi.Models.Common.Tip
{
    public class CompleteTip : CompactTip
    {
        public TipLikes Likes { get; set; }
        public TipTodo Todo { get; set; }
    }

    public class TipLikes
    {
        public int Count { get; set; }
        public IEnumerable<TipLikesGroup> Groups { get; set; }
    }

    public class TipLikesGroup
    {
        public string Type { get; set; }
        public int Count { get; set; }
        public IEnumerable<CompactUser> Items { get; set; } 
    }

    public class TipTodo
    {
        public int Count { get; set; }
        public IEnumerable<TipTodoGroup> Groups { get; set; }
    }

    public class TipTodoGroup
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public IEnumerable<CompactUser> Items { get; set; } 
    }
}
