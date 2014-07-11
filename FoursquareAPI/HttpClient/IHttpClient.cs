using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClient
{
    public interface IHttpClient
    {
        IHttpResult<TResult> SendGetRequest<TResult>(string url);
        IHttpResult<TResult> SendPostRequest<TResult, TInput>(string url, TInput obj);
    }
}
