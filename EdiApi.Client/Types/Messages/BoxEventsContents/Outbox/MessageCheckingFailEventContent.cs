namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии MessageCheckingFail</summary>
    public class MessageCheckingFailEventContent : OutboxEventContentBase
    {
        /// <summary>Ошибки, обнаруженные в сообщении, не прошедшем проверку</summary>
        public string[] Errors { get; set; }

        /// <summary>Номер статусного сообщения, соответствующего данному событию. Актуален только для статусных сообщений, отправляемых по схеме с формированием документов после проверки сообщения Invoic</summary>
        public string ReportNumber { get; set; }
    }
}