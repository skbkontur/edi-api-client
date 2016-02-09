using KonturEdi.Api.Types.BoxEvents;

namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox
{
    public abstract class MessageOutboxEventContent : IBoxEventContent
    {
        public virtual bool IsEmpty()
        {
            return OutboxMessageMeta == null;
        }

        public BasicMessageMeta OutboxMessageMeta { get; set; }
    }
}