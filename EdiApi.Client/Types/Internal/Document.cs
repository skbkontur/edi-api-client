using System;

using SkbKontur.EdiApi.Types.Internal.DocumentSpecificFields;
using SkbKontur.EdiApi.Types.Messages;
using SkbKontur.EdiApi.Types.Messages.BoxEventsContents;

namespace SkbKontur.EdiApi.Types.Internal
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
        public IftmbfFields IftmbfFields { get; set; }
        public IftmbcFields IftmbcFields { get; set; }
    }
}