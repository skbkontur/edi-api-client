namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии RecognizeMessage</summary>
    public class RecognizeMessageEventContent : OutboxEventContentBase
    {
        /// <summary>Тип сообщения</summary>
        public DocumentType DocumentType { get; set; }

        /// <summary>Отправитель сообщения</summary>
        public string SenderPartyId { get; set; }

        /// <summary>Получатель сообщения</summary>
        public string RecipientPartyId { get; set; }
    }
}