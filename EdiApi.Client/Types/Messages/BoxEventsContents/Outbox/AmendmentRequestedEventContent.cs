using JetBrains.Annotations;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    public class AmendmentRequestedEventContent : OutboxDiadocEventContentBase
    {
        [CanBeNull]
        public string AmendmentRequestMessage { get; set; }
    }
}