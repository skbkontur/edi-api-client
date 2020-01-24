using System;

using SkbKontur.EdiApi.Types.Internal.GoodItems;

namespace SkbKontur.EdiApi.Types.Internal.DocumentSpecificFields
{
    public class RetinsFields : OrderBasedDocumentFields
    {
        public string CurrencyCode { get; set; }

        public DocumentRevisionType DocumentRevisionType { get; set; }

        public DateTime? ShippingDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? AvailabilityDate { get; set; }

        public string RetannNumber { get; set; }
        public DateTime? RetannDate { get; set; }

        public string DespatchAdviceNumber { get; set; }
        public DateTime? DespatchDate { get; set; }

        public string ReturnDeliveryNoteNumber { get; set; }
        public DateTime? ReturnDeliveryNoteDate { get; set; }

        public string DeliveryNoteNumber { get; set; }
        public DateTime? DeliveryNoteDate { get; set; }

        public string ReturnInvoicNumber { get; set; }
        public DateTime? ReturnInvoicDate { get; set; }

        public PhysicalOrLogicalState[] ReturnPhysicalOrLogicalStates { get; set; }

        public decimal? RetinsTotalVAT { get; set; }
        public decimal? RetinsTotalWithVat { get; set; }
        public decimal? RetinsTotal { get; set; }
        public RetinsGoodItem[] GoodItems { get; set; }
    }
}