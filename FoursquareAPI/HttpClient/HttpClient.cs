using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HttpClient.SerializationService;

namespace HttpClient
{
    public sealed class HttpClient : IHttpClient
    {
        private readonly ISerializationService _serializationService;
        public HttpClient(ISerializationService serializationService)
        {
            _serializationService = serializationService;
        }
        public IHttpResult<TResult> SendGetRequest<TResult>(string requestUrl)
        {
            try
            {
                var webRequest = CreateHttpRequest(requestUrl, HttpMethodType.Get);
                HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
                using (var responseStream = webResponse.GetResponseStream())
                {
                    string responseStr = string.Empty;
                    if (responseStream != null)
                         responseStr = new StreamReader(responseStream).ReadToEnd();
                    var obj = _serializationService.Deserialize<TResult>(responseStr);

                    return new HttpResult<TResult>(obj, null);
                }
            }
            catch (WebException exception)
            {
                var error = string.Format("Message:{0}, Url:{1}",exception.Message,requestUrl);
                return new HttpResult<TResult>(error);
            }
        }

        public IHttpResult<TResult> SendPostRequest<TResult, TInput>(string requestUrl, TInput obj)
        {
            try
            {
                var serializedObject = _serializationService.Serialize(obj);
                var data = Encoding.UTF8.GetBytes(serializedObject);
                var webRequest = CreateHttpRequest(requestUrl, HttpMethodType.Post);
                using (var requestStream = webRequest.GetRequestStream())
                {
                    requestStream.Write(data, 0, data.Length);
                }
                var webResponse = webRequest.GetResponse();
                using (var responseStream = webResponse.GetResponseStream())
                {
                    string responseStr = string.Empty;
                    if (responseStream != null)
                        responseStr = new StreamReader(responseStream).ReadToEnd();
                    var responseObj = _serializationService.Deserialize<TResult>(responseStr);
                    
                    return new HttpResult<TResult>(responseObj, null);
                }
            }
            catch (WebException exception)
            {
                var error = string.Format("Message:{0}, Url:{1}", exception.Message, requestUrl);
                return new HttpResult<TResult>(error);
            }
        }

        private HttpWebRequest CreateHttpRequest(string requestUrl,string requestType)
        {
            HttpWebRequest webRequest = WebRequest.CreateHttp(requestUrl);
            webRequest.Method = requestType;
            webRequest.Accept = HttpContentType.JsonContentType;
            webRequest.UseDefaultCredentials = true;
            return webRequest;
        }
    }
}
