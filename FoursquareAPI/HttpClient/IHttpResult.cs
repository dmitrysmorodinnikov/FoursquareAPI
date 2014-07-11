using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClient
{
    public interface IHttpResult<TResult>
    {
        string GetError();
        bool IsSuccess { get; }
        TResult Result { get; }
    }
}
