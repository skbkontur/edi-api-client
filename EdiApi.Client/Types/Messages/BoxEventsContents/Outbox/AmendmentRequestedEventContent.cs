#nullable enable

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    public class AmendmentRequestedEventContent : OutboxDiadocEventContentBase
    {
        public string? AmendmentRequestMessage { get; set; }
    }
}