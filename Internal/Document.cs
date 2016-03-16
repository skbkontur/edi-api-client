using System;

using KonturEdi.Api.Types.Internal.DocumentSpecificFields;
using KonturEdi.Api.Types.Messages;
using KonturEdi.Api.Types.Organization;

namespace KonturEdi.Api.Types.Internal
{
    public class Document
    {
        public DocumentId DocumentId { get; set; }
        public string DocumentCirculationId { get; set; }
        public DocumentType Type { get; set; }
        public string Kind { get; set; }
        public PartyInfo Recipient { get; set; }
        public PartyInfo Sender { get; set; }
        public DateTime? CreationDateTimeBySender { get; set; }
        public string Number { get; set; }
        public DateTime? Date { get; set; }

        public OrdersFields OrdersFields { get; set; }
        public DesadvFields DesadvFields { get; set; }
        public DesadvViaInvoicFields DesadvViaInvoicFields { get; set; }
        public OrdrspFields OrdrspFields { get; set; }
        public RecadvFields RecadvFields { get; set; }
        public InvoicFields InvoicFields { get; set; }
        public RetannFields RetannFields { get; set; }
        public POrdersFields POrdersFields { get; set; }
        public PricatFields PricatFields { get; set; }
        public PricatFields PriceListFields { get; set; }
        public RetdesFields RetdesFields { get; set; }
        public RetrecFields RetrecFields { get; set; }
        public AlcrptFields AlcrptFields { get; set; }
        public CoinvoicFields CoinvoicFields { get; set; }
    }

    public class DocumentId
    {
        public string BoxId { get; set; }
        public string EntityId { get; set; }
    }
}