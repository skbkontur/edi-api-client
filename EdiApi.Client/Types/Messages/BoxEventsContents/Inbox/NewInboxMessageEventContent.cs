using SkbKontur.EdiApi.Client.Types.BoxEvents;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    public class NewInboxMessageEventContent : IBoxEventContent
    {
        public InboxMessageMeta InboxMessageMeta { get; set; }
    }
}