namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии ReceivedDiadocRoamingError</summary>
    public class MessageReceivedDiadocRoamingErrorEventContent : OutboxDiadocEventContentBase
    {
        /// <summary>Ошибки, обнаруженные в документах, не прошедших проверку у получателя</summary>
        public string Reason { get; set; }
    }
}