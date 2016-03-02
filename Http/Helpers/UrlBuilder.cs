using System;
using System.Collections.Generic;
using System.Text;

namespace KonturEdi.Api.Client.Http.Helpers
{
    public class UrlBuilder
    {
        public UrlBuilder(Uri uri, string relativeUrl)
            : this(new Uri(uri, relativeUrl))
        {
        }

        public UrlBuilder(Uri baseUri)
        {
            if(!string.IsNullOrEmpty(baseUri.Query))
                throw new ArgumentException(string.Format("Base uri with non empty query is not supported: {0}", baseUri));
            this.baseUri = baseUri;
        }

        public UrlBuilder AddParameter(string name, string value)
        {
            queryParams.Add(name, value);
            return this;
        }

        public UrlBuilder AddParameter(string name, int value)
        {
            return AddParameter(name, value.ToString());
        }

        public Uri ToUri()
        {
            return new UriBuilder(baseUri) {Query = BuildQuery()}.Uri;
        }

        private string BuildQuery()
        {
            var sb = new StringBuilder();
            var isFrist = true;
            foreach(var kvp in queryParams)
            {
                if(!isFrist)
                    sb.Append("&");
                isFrist = false;
                sb.Append(kvp.Key).Append("=").Append(string.IsNullOrEmpty(kvp.Value) ? kvp.Value : Uri.EscapeDataString(kvp.Value));
            }
            return sb.ToString();
        }

        private readonly Uri baseUri;
        private readonly Dictionary<string, string> queryParams = new Dictionary<string, string>();
    }
}