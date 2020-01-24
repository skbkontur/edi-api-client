using KonturEdi.Api.Types.BoxEvents;

namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Inbox
{
    public abstract class InboxDiadocEventContentBase : DiadocEventContentBase, IBoxEventContent
    {
        public BasicMessageMeta InboxMessageMeta { get; set; }
    }
}