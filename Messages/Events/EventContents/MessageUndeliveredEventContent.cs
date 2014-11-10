namespace KonturEdi.Api.Types.Messages.Events.EventContents
{
    public class MessageUndeliveredEventContent : IBoxEventContent
    {
        public bool IsEmpty()
        {
            return OutboxMessageMeta == null;
        }

        public OutboxMessageMeta OutboxMessageMeta { get; set; }
        public string[] MessageUndeliveryReasons { get; set; }
    }
}