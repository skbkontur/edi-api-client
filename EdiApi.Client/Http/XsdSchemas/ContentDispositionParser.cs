using System;

namespace SkbKontur.EdiApi.Client.Http.XsdSchemas
{
    public static class ContentDispositionParser
    {
        public static (string filname, string version) Parse(string contentDisposition)
        {
            const string parameter = "filename=";

            var filenameStartIdx = contentDisposition.IndexOf(parameter, StringComparison.OrdinalIgnoreCase) + parameter.Length;
            var filenameEndIdx = contentDisposition.IndexOf(';', filenameStartIdx);
            var filename = contentDisposition.Substring(filenameStartIdx, filenameEndIdx - filenameStartIdx);

            var version = filename.Substring(0, filename.Contains("-") ? filename.IndexOf('-') : filename.LastIndexOf('.'));

            return (filename, version);
        }
    }
}