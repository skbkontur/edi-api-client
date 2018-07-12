using System;

using KonturEdi.Api.Types.Internal.GoodItems;

namespace KonturEdi.Api.Types.Internal.DocumentSpecificFields
{
    public class RecadvFields : OrderBasedDocumentFields
    {
        public DateTime? AcceptanceDate { get; set; }

        public string DespatchAdviceNumber { get; set; }

        public DateTime? DespatchDate { get; set; }

        public string ReceivingAdviceNumberInBuyerSystem { get; set; }

        public RecadvTransportDetails TransportDetails { get; set; }

        public string TransportBy { get; set; }

        public string CurrencyCode { get; set; }

        public decimal? RecadvTotal { get; set; }
        public decimal? RecadvTaxableTotal { get; set; }
        public decimal? RecadvTotalWithVAT { get; set; }
        public decimal? RecadvTotalVAT { get; set; }

        public DocumentRevisionType? DocumentRevisionType { get; set; }
        public CommonGoodItem[] GoodItems { get; set; }
    }

    public class RecadvTransportDetails
    {
        public string VehicleNumber { get; set; }
    }
}