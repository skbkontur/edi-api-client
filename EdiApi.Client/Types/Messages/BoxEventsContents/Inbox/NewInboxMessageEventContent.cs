using SkbKontur.EdiApi.Types.BoxEvents;

namespace SkbKontur.EdiApi.Types.Messages.BoxEventsContents.Inbox
{
    public class NewInboxMessageEventContent : IBoxEventContent
    {
        public InboxMessageMeta InboxMessageMeta { get; set; }
    }
}