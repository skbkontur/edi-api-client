namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии DiadocRevocationAccepted</summary>
    public class MessageDiadocRevocationAcceptedEventContent : OutboxDiadocEventContentBase
    {
        /// <summary>Информация об аннулированном документе</summary>
        public RevocationInfo AcceptedRevocationInfo { get; set; }
    }
}