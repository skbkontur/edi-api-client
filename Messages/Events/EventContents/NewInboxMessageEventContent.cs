namespace KonturEdi.Api.Types.Messages.Events.EventContents
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