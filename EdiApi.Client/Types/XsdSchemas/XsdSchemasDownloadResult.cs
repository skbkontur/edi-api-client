using System.IO;

namespace SkbKontur.EdiApi.Client.Types.XsdSchemas
{
    public class XsdSchemasDownloadResult
    {
        public string Version { get; set; }
        public string FileName { get; set; }
        public long Length { get; set; }
        public Stream ContentStream { get; set; }
    }
}