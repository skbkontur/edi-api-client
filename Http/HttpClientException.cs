using System;
using System.IO;
using System.Net;
using System.Text;

namespace KonturEdi.Api.Client.Http
{
    public class HttpClientException : Exception
    {
        private HttpClientException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public static HttpClientException Create(WebException exception, Uri requestUri)
        {
            var message = "Request for url '" + requestUri + "' failed";
            var response = exception.Response as HttpWebResponse;
            if (response == null)
                return new HttpClientException(message, exception);
            string serverMessage;
            using (var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                serverMessage = reader.ReadToEnd();
            var serverException = string.IsNullOrEmpty(serverMessage) ? null : new HttpClientServerException(serverMessage, exception);
            return new HttpClientException(message, serverException);
        }
    }

    public class HttpClientServerException : Exception
    {
        protected internal HttpClientServerException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}