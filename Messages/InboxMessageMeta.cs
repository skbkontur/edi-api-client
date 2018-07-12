using System;

namespace KonturEdi.Api.Types.Messages
{
    public class InboxMessageMeta : BasicMessageMeta
    {
        public DateTime SendDateTime { get; set; }
        public Partner Sender { get; set; }
        public MessageFormat MessageFormat { get; set; }
        public DocumentDetails DocumentDetails { get; set; }
    }
}