using System;
using System.IO;
using System.Net;
using System.Text;

namespace SkbKontur.EdiApi.Client.Http
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
            if (!(exception.Response is HttpWebResponse response))
                return new HttpClientException(message, exception);
            string serverMessage = null;
            var responseStream = response.GetResponseStream();
            if (responseStream != null)
            {
                using (var reader = new StreamReader(responseStream, Encoding.UTF8))
                    serverMessage = reader.ReadToEnd();
            }
            var serverException = new HttpClientServerException(serverMessage, exception);
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