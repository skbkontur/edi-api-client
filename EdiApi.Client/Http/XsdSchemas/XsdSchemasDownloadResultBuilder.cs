using SkbKontur.EdiApi.Client.Types.XsdSchemas;

using Vostok.Clusterclient.Core.Model;

namespace SkbKontur.EdiApi.Client.Http.XsdSchemas
{
    public static class XsdSchemasDownloadResultBuilder
    {
        public static XsdSchemasDownloadResult Build(Response response)
        {
            var (filename, version) = ContentDispositionParser.Parse(response.Headers["content-disposition"]);

            return new XsdSchemasDownloadResult
                {
                    Version = version,
                    FileName = filename,
                    Content = response.Content.ToArray(),
                };
        }
    }
}