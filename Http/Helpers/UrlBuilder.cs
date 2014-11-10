using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KonturEdi.Api.Client.Http.Helpers
{
    public class UrlBuilder
    {
        public UrlBuilder(Uri uri)
        {
            uriBuilder = new UriBuilder(uri) {Query = ""};
            ParseQuery(uri.Query);
        }

        public UrlBuilder(Uri uri, string relativeUrl)
            : this(new Uri(uri, relativeUrl))
        {
        }

        public UrlBuilder AddParameter(string name, string value)
        {
            dict.Add(name, value);
            return this;
        }

        public UrlBuilder AddParameter(string name, int value)
        {
            return AddParameter(name, value.ToString());
        }

        public Uri ToUri()
        {
            uriBuilder.Query = GetQueryString();
            return uriBuilder.Uri;
        }

        private string GetQueryString()
        {
            var stringBuilder = new StringBuilder();
            var isFrist = true;
            foreach(var kvp in dict)
            {
                if(!isFrist)
                    stringBuilder.Append("&");
                isFrist = false;
                stringBuilder.Append(kvp.Key).Append("=").Append(string.IsNullOrEmpty(kvp.Value) ? kvp.Value : kvp.Value.Replace("+", "%2B"));//TODO fast fix, но нужно решение по лучше
            }
            return stringBuilder.ToString();
        }

        private void ParseQuery(string query)
        {
            if(string.IsNullOrEmpty(query))
                return;
            if(query[0] != '?')
                throw new Exception(string.Format("What is strange query '{0}'???", query));
            var pairs = query.Substring(1).Split(new[] {'&'});
            dict = pairs.Select(pair =>
                {
                    var tokens = pair.Split(new[] {'='}, 2);
                    if(tokens.Length != 2)
                        throw new Exception(string.Format("What is strange query '{0}'???", query));
                    return new KeyValuePair<string, string>(tokens[0], tokens[1]);
                }).ToDictionary(x => x.Key, x => x.Value);
        }

        private Dictionary<string, string> dict = new Dictionary<string, string>();
        private readonly UriBuilder uriBuilder;
    }
}