using System;

using SkbKontur.EdiApi.Client.Types.Internal.GoodItems;

namespace SkbKontur.EdiApi.Client.Types.Internal.DocumentSpecificFields
{
    public class CoinvoicFields : OrderBasedDocumentFields
    {
        public DocumentRevisionType DocumentRevisionType { get; set; }
        public string FactoringEncription { get; set; }
        public string InvoicNumber { get; set; }
        public DateTime? InvoicDate { get; set; }
        public string EdiInvoicId { get; set; }
        public string DiadocInvoicId { get; set; }
        public string InvoicRevisionNumber { get; set; }
        public DateTime? InvoicRevisionDate { get; set; }
        public string CoinvoicRevisionNumber { get; set; }
        public DateTime? CoinvoicRevisionDate { get; set; }
        public string OrderResponseNumber { get; set; }
        public DateTime? OrderResponseDate { get; set; }
        public string ReceivingAdviceNumber { get; set; }
        public DateTime? ReceivingDate { get; set; }
        public string DespatchAdviceNumber { get; set; }
        public DateTime? DespatchDate { get; set; }
        public string GovernmentContractId { get; set; }
        public string CurrencyCode { get; set; }
        public CoinvoicGoodItem[] GoodItems { get; set; }
        public CoinvoicBeforeAfter<decimal?> InvoicTaxableTotal { get; set; }
        public CoinvoicBeforeAfter<decimal?> InvoicTotalWithVAT { get; set; }
        public CoinvoicBeforeAfter<decimal?> InvoicTotalVAT { get; set; }
        public CoinvoicBeforeAfter<decimal?> InvoicTotalWithVATForIV { get; set; }
        public CoinvoicBeforeAfter<decimal?> InvoicTaxableTotalForIV { get; set; }
        public CoinvoicBeforeAfter<decimal?> InvoicTotalVATForIV { get; set; }
    }
}