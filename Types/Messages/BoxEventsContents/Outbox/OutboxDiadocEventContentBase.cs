using KonturEdi.Api.Types.BoxEvents;

namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox
{
    public abstract class OutboxDiadocEventContentBase : DiadocEventContentBase, IBoxEventContent
    {
        public BasicMessageMeta OutboxMessageMeta { get; set; }
    }
}