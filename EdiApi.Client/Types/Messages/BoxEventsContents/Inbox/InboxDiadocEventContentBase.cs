using SkbKontur.EdiApi.Client.Types.BoxEvents;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    public abstract class InboxDiadocEventContentBase : DiadocEventContentBase, IBoxEventContent
    {
        public BasicMessageMeta InboxMessageMeta { get; set; }
    }
}