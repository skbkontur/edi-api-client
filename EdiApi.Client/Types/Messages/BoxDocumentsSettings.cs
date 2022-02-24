namespace SkbKontur.EdiApi.Client.Types.Messages
{
    /// <summary>Настройка возможности обмена документами с различными контрагентами в рамках одного ящика</summary>
    public class BoxDocumentsSettings
    {
        /// <summary>Идентификатор ящика</summary>
        public string BoxId { get; set; }

        /// <summary>Настройки документов по контрагентам</summary>
        public DocumentsSettingsForPartner[] DocumentsSettingsForPartner { get; set; }
    }
}