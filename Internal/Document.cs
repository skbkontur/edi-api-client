using System;

using KonturEdi.Api.Types.Internal.DocumentSpecificFields;
using KonturEdi.Api.Types.Messages;
using KonturEdi.Api.Types.Messages.BoxEventsContents;

namespace KonturEdi.Api.Types.Internal
{
    public class Document
    {
        public DocumentId DocumentId { get; set; }
        public string DocumentCirculationId { get; set; }
        public DocumentType Type { get; set; }
        public string SenderPartyId { get; set; }
        public string RecipientPartyId { get; set; }
        public DateTime? CreationDateTimeBySender { get; set; }
        public string Number { get; set; }
        public DateTime? Date { get; set; }
        public LinkedDocumentInfo[] LinkedDocuments { get; set; }

        public OrdersFields OrdersFields { get; set; }
        public DesadvFields DesadvFields { get; set; }
        public OrdrspFields OrdrspFields { get; set; }
        public RecadvFields RecadvFields { get; set; }
        public InvoicFields InvoicFields { get; set; }
        public RetannFields RetannFields { get; set; }
        public RetinsFields RetinsFields { get; set; }
        public POrdersFields POrdersFields { get; set; }
        public PriceListFields PriceListFields { get; set; }
        public RetdesFields RetdesFields { get; set; }
        public RetrecFields RetrecFields { get; set; }
        public RetinvFields RetinvFields { get; set; }
        public AlcrptFields AlcrptFields { get; set; }
        public CoinvoicFields CoinvoicFields { get; set; }
        public PartinFields PartinFields { get; set; }
        public InvrptFields InvrptFields { get; set; }
        public SlsrptFields SlsrptFields { get; set; }
        public DelforFields DelforFields { get; set; }
    }
}