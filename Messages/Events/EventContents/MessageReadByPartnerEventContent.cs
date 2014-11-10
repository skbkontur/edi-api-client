namespace KonturEdi.Api.Types.Messages.Events.EventContents
{
    public class MessageReadByPartnerEventContent : IBoxEventContent
    {
        public bool IsEmpty()
        {
            return OutboxMessageMeta == null;
        }

        public OutboxMessageMeta OutboxMessageMeta { get; set; }
    }
}