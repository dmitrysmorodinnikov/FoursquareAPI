using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FoursquareApi.Services
{
    internal static class QueryStringHelper
    {
        internal static string BuildQueryString(Dictionary<string, string> argsDictionary)
        {
            var sb = new StringBuilder("?");
            foreach (var item in argsDictionary)
            {
                sb.AppendFormat("{0}={1}", item.Key, HttpUtility.UrlEncode(item.Value));
                sb.Append("&");
            }
            if (sb.Length > 0) sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        internal static string BuildPostData(Dictionary<string, string> argsDictionary)
        {
            var sb = new StringBuilder();
            foreach (var item in argsDictionary)
            {
                sb.AppendFormat("{0}={1}", item.Key, HttpUtility.UrlEncode(item.Value));
                sb.Append("&");
            }
            if (sb.Length > 0) sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
    }
}
