namespace SkbKontur.EdiApi.Types.Messages.BoxEventsContents.Outbox
{
    public class MessageCheckingOkEventContent : OutboxEventContentBase
    {
        public string[] Warnings { get; set; }
        public string ReportNumber { get; set; }
    }
}