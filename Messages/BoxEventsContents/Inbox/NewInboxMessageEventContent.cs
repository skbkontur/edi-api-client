using KonturEdi.Api.Types.BoxEvents;

namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Inbox
{
    public class NewInboxMessageEventContent : IBoxEventContent
    {
        public InboxMessageMeta InboxMessageMeta { get; set; }
    }
}