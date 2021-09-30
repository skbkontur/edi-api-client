namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Идентификатор документа в ящике</summary>
    public class DocumentId
    {
        /// <summary>Идентификатор ящика организации</summary>
        public string BoxId { get; set; }
        /// <summary>Идентификатор сущности документа в ящике организации</summary>
        public string EntityId { get; set; }
    }
}