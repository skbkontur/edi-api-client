using System;

using Vostok.Clusterclient.Core.Model;

namespace SkbKontur.EdiApi.Client.Http
{
    public class HttpClientException : Exception
    {
        private HttpClientException(string message, ResponseCode statusCode, Exception innerException)
            : base(message, innerException) =>
            StatusCode = statusCode;

        private HttpClientException(string message, ResponseCode statusCode)
            : base(message) =>
            StatusCode = statusCode;

        public ResponseCode StatusCode { get; }

        public static HttpClientException Create(ClusterResult result)
        {
            var message = "Request for url '" + result.Request.Url + "' failed";

            var statusCode = result.Response.Code;

            if (!result.Response.HasContent)
            {
                return new HttpClientException(message, statusCode);
            }
            return new HttpClientException(message, statusCode, new HttpClientServerException(result.Response.Content.ToString()));
        }
    }

    public class HttpClientServerException : Exception
    {
        protected internal HttpClientServerException(string message)
            : base(message)
        {
        }
    }
}