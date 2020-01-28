namespace SkbKontur.EdiApi.Client.Types.Messages
{
    public class BoxDocumentsSettings
    {
        public string BoxId { get; set; }
        public DocumentsSettingsForPartner[] DocumentsSettingsForPartner { get; set; }
    }
}