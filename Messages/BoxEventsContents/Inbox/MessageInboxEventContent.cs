using KonturEdi.Api.Types.BoxEvents;

namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Inbox
{
    public abstract class MessageInboxEventContent : IBoxEventContent
    {
        public abstract bool IsEmpty();
    }
}