namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    public class MessageCheckingFailEventContent : OutboxEventContentBase
    {
        public string[] Errors { get; set; }
        public string ReportNumber { get; set; }
    }
}