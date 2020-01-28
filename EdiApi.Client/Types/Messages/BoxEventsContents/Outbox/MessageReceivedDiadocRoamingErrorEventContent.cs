namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    public class MessageReceivedDiadocRoamingErrorEventContent : OutboxDiadocEventContentBase
    {
        public string Reason { get; set; }
    }
}