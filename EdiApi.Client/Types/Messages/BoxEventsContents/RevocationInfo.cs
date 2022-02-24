namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Информация об аннулировании документа</summary>
    public class RevocationInfo
    {
        /// <summary>Тип аннулированного документа</summary>
        public DiadocDocumentType DiadocDocumentType { get; set; }

        /// <summary>Причина аннулирования</summary>
        public string RevocationReason { get; set; }
    }
}