using KonturEdi.Api.Types.BoxEvents;

namespace KonturEdi.Api.Types.Messages.BoxEventsContents
{
    public class NewInboxMessageEventContent : IBoxEventContent
    {
        public bool IsEmpty()
        {
            return InboxMessageMeta == null;
        }

        public InboxMessageMeta InboxMessageMeta { get; set; }
    }
}