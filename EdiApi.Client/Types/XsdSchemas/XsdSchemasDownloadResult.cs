namespace SkbKontur.EdiApi.Client.Types.XsdSchemas
{
    public class XsdSchemasDownloadResult
    {
        public string Version { get; set; }
        public string FileName { get; set; }
        public byte[] Content { get; set; }
    }
}