using System;

using KonturEdi.Api.Types.Internal.GoodItems;

namespace KonturEdi.Api.Types.Internal.DocumentSpecificFields
{
    public class RetannFields : OrderBasedDocumentFields
    {
        public string CurrencyCode { get; set; }

        public DocumentRevisionType? DocumentRevisionType { get; set; }

        public DateTime? DeliveryDate { get; set; }
        public DateTime? AvailabilityDate { get; set; }

        public string DespatchAdviceNumber { get; set; }
        public DateTime? DespatchDate { get; set; }

        public string DeliveryNoteNumber { get; set; }
        public DateTime? DeliveryNoteDate { get; set; }

        public string ReceivingAdviceNumber { get; set; }
        public DateTime? ReceivingDate { get; set; }

        public string ReturnInvoicNumber { get; set; }
        public DateTime? ReturnInvoicDate { get; set; }

        public decimal? RetannTotalVAT { get; set; }
        public decimal? RetannTotalWithVat { get; set; }
        public decimal? RetannTotal { get; set; }
        public RetannGoodItem[] GoodItems { get; set; }
    }
}