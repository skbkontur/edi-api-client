namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии MessageCheckingOk</summary>
    public class MessageCheckingOkEventContent : OutboxEventContentBase
    {
        /// <summary>Замечания к сообщению, прошедшему проверку</summary>
        public string[] Warnings { get; set; }
        /// <summary>Номер статусного сообщения, соответствующего данному событию. Актуален только для статусных сообщений, отправляемых по схеме с формированием документов после проверки сообщения Invoic</summary>
        public string ReportNumber { get; set; }
    }
}