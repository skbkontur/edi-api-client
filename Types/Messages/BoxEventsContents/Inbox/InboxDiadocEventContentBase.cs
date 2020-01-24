using SkbKontur.EdiApi.Types.BoxEvents;

namespace SkbKontur.EdiApi.Types.Messages.BoxEventsContents.Inbox
{
    public abstract class InboxDiadocEventContentBase : DiadocEventContentBase, IBoxEventContent
    {
        public BasicMessageMeta InboxMessageMeta { get; set; }
    }
}