using KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox;

namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Inbox
{
    public class MessageDraftOfDocumentPackageSignedBySenderEventContent : MessageInboxEventContent, IMessageDiadocEventContent
    {
        public BasicMessageMeta InboxMessageMeta { get; set; }

        public string DiadocBoxId { get; set; }
        public string InvoiceId { get; set; }
        public string MessageId { get; set; }
        public string Torg12Id { get; set; }
        public DiadocUrls DiadocUrls { get; set; }

        public override bool IsEmpty()
        {
            return InboxMessageMeta == null;
        }
    }
}