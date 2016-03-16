using System;

using KonturEdi.Api.Types.Internal.GoodItems;

namespace KonturEdi.Api.Types.Internal.DocumentSpecificFields
{
    public class DesadvViaInvoicFields : OrderBasedDocumentFields
    {
        public DateTime? ShippingDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }

        public string CurrencyCode { get; set; }

        public string TransportBy { get; set; }

        public decimal? DesadvTotal { get { return desadvTotal ?? desadvTaxableTotal; } set { desadvTotal = value; } }
        public decimal? DesadvTotalWithVAT { get; set; }
        public decimal? DesadvTotalVAT { get; set; }
        public decimal? DesadvTaxableTotal { get { return desadvTaxableTotal ?? desadvTotal; } set { desadvTaxableTotal = value; } }
        public CommonGoodItem[] GoodItems { get; set; }

        private decimal? desadvTotal;
        private decimal? desadvTaxableTotal;
    }
}