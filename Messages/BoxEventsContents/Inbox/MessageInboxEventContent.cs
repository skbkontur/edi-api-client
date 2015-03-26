using KonturEdi.Api.Types.BoxEvents;

namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Inbox
{
    public class MessageInboxEventContent : IBoxEventContent
    {
        public virtual bool IsEmpty()
        {
            return InboxMessageMeta == null;
        }

        public InboxMessageMeta InboxMessageMeta { get; set; }
    }
}