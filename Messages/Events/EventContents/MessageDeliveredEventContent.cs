namespace KonturEdi.Api.Types.Messages.Events.EventContents
{
    public class MessageDeliveredEventContent : IBoxEventContent
    {
        public bool IsEmpty()
        {
            return OutboxMessageMeta == null;
        }

        public OutboxMessageMeta OutboxMessageMeta { get; set; }
    }
}