using System.IO;
using System.Net;
using System.Text;

namespace KonturEdi.Api.Client.Http
{
    public static class WebExtensions
    {
        public static byte[] GetBytes(this string data)
        {
            return Encoding.UTF8.GetBytes(data);
        }

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
    }
}