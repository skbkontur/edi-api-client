namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии MessageUndelivered</summary>
    public class MessageUndeliveredEventContent : OutboxEventContentBase
    {
        /// <summary>Описание причин, по которым сообщение не доставлено</summary>
        public string[] MessageUndeliveryReasons { get; set; }
    }
}