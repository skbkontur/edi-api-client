using System;

using KonturEdi.Api.Types.Internal.GoodItems;

namespace KonturEdi.Api.Types.Internal.DocumentSpecificFields
{
    public class DesadvFields : OrderBasedDocumentFields
    {
        public DateTime? ShippingDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public string OrderResponseNumber { get; set; }

        public DateTime? OrderResponseDate { get; set; }

        public string InvoiceNumber { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public DesadvTransportDetails TransportDetails { get; set; }

        public string CurrencyCode { get; set; }

        public string TransportBy { get; set; }

        public decimal? DesadvTotal { get { return desadvTotal ?? desadvTaxableTotal; } set { desadvTotal = value; } }
        public decimal? DesadvTotalWithVAT { get; set; }
        public decimal? DesadvTotalVAT { get; set; }
        public decimal? DesadvTaxableTotal { get { return desadvTaxableTotal ?? desadvTotal; } set { desadvTaxableTotal = value; } }

        public DocumentRevisionType DocumentRevisionType { get; set; }
        public CommonGoodItem[] GoodItems { get; set; }

        private decimal? desadvTotal;
        private decimal? desadvTaxableTotal;
    }

    public class DesadvTransportDetails
    {
        public string TransportMode { get; set; }
        public string NameOfCarrier { get; set; }
        public string VehicleNumber { get; set; }
        public string VehicleBrand { get; set; }
    }
}