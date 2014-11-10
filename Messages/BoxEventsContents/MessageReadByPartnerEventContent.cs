using KonturEdi.Api.Types.BoxEvents;

namespace KonturEdi.Api.Types.Messages.BoxEventsContents
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