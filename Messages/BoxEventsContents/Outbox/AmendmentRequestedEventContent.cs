using JetBrains.Annotations;

namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox
{
    public class AmendmentRequestedEventContent : OutboxDiadocEventContentBase
    {
        [NotNull]
        public string AmendmentRequestMessage { get; set; }
    }
}