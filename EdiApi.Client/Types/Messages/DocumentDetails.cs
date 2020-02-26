using System;

namespace SkbKontur.EdiApi.Client.Types.Messages
{
    public class DocumentDetails
    {
        public DocumentType DocumentType { get; set; }
        public bool DocumentIsTest { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string DeliveryPartyGln { get; set; }
    }
}