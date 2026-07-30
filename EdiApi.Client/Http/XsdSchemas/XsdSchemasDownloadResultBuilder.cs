using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

using SkbKontur.EdiApi.Client.Types.XsdSchemas;

using Vostok.Clusterclient.Core.Model;

namespace SkbKontur.EdiApi.Client.Http.XsdSchemas
{
    internal static class XsdSchemasDownloadResultBuilder
    {
        internal static XsdSchemasDownloadResult Build(Response response)
        {
            var contentDisposition = response.Headers["content-disposition"];
            if (contentDisposition is null)
                throw new HttpClientServerException("Unexpected server response: content-disposition header missing");

            if (!ContentDispositionHeaderValue.TryParse(contentDisposition, out var contentDispositionHeader))
                throw new HttpClientServerException("Unexpected server response: content-disposition header has invalid format");

            var filename = contentDispositionHeader.FileName;

            if (!TryExtractVersion(filename, out var version))
                throw new HttpClientServerException("Unexpected server response: filename format is invalid");

            return new XsdSchemasDownloadResult
                {
                    Version = version,
                    FileName = filename,
                    Content = response.Content.ToArray(),
                };
        }

        private static bool TryExtractVersion(string filename, out string version)
        {
            version = null;

            if (string.IsNullOrEmpty(filename))
                return false;

            var match = filenameRegex.Match(filename);
            if (!match.Success ||
                !DateTime.TryParseExact(match.Groups["date"].Value, "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _) ||
                !int.TryParse(match.Groups["revision"].Value, NumberStyles.None, CultureInfo.InvariantCulture, out _))
            {
                return false;
            }

            version = match.Groups["version"].Value;
            return true;
        }

        private static readonly Regex filenameRegex = new Regex(@"^(?<version>(?<date>\d{4}\.\d{2}\.\d{2})\.(?<revision>[1-9]\d{0,9}))(?:-tns)?\.zip$",
                                                                RegexOptions.Compiled | RegexOptions.CultureInvariant);
    }
}