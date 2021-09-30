namespace SkbKontur.EdiApi.Client.Types.Messages
{
    /// <summary>Атомарная настройка возможности отправлять/получать документ определенного типа</summary>
    public class DocumentSettings
    {
        /// <summary>Тип документа</summary>
        public DocumentType DocumentType { get; set; }
        /// <summary>Направление документа</summary>
        public DocumentDirection DocumentDirection { get; set; }
    }
}