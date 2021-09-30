namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии DiadocRevocationRequested</summary>
    public class MessageDiadocRevocationRequestedEventContent : OutboxDiadocEventContentBase
    {
        /// <summary>Информация об аннулировании документа</summary>
        public RevocationInfo RevocationInfo { get; set; }
    }
}