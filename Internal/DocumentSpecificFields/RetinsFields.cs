using System;

using KonturEdi.Api.Types.Internal.GoodItems;

namespace KonturEdi.Api.Types.Internal.DocumentSpecificFields
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

        public string ReturnDespatchAdviceNumber { get; set; }
        public DateTime? ReturnDespatchDate { get; set; }

        public string ReturnInvoicNumber { get; set; }
        public DateTime? ReturnInvoicDate { get; set; }

        //public PhysicalOrLogicalState[] ReturnPhysicalOrLogicalStates { get; set; }

        public decimal? RetinsTotalVAT { get; set; }
        public decimal? RetinsTotalWithVat { get; set; }
        public decimal? RetinsTotal { get; set; }
        public RetinsGoodItem[] GoodItems { get; set; }
    }
}