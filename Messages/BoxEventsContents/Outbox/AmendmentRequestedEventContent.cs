namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox
{
    public class AmendmentRequestedEventContent : OutboxDiadocEventContentBase
    {
        public string AmendmentRequestMessage { get; set; }
    }
}