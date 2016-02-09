namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Inbox
{
    public class NewInboxMessageEventContent : MessageInboxEventContent
    {
        public InboxMessageMeta InboxMessageMeta { get; set; }

        public override bool IsEmpty()
        {
            return InboxMessageMeta == null;
        }
    }
}