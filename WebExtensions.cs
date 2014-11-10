using System.IO;
using System.Net;
using System.Text;

namespace KonturEdi.Api.Client
{
    public static class WebExtensions
    {
        public static string GetString(this WebResponse response)
        {
            var responseStream = response.GetResponseStream();
            var responseLength = (int)response.ContentLength;
            using (var binaryReader = new BinaryReader(responseStream))
            {
                var bytes = binaryReader.ReadBytes(responseLength);
                return Encoding.UTF8.GetString(bytes);
            }
        }

        public static WebResponse GetWebResponse(this WebRequest request)
        {
            try
            {
                return request.GetResponse();
            }
            catch (WebException exception)
            {
                throw HttpClientException.Create(exception, request.RequestUri);
            }
        }
    }
}