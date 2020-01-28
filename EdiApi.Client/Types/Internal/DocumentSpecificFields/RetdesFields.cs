using System;

using SkbKontur.EdiApi.Client.Types.Internal.GoodItems;

namespace SkbKontur.EdiApi.Client.Types.Internal.DocumentSpecificFields
{
    public class RetdesFields : OrderBasedDocumentFields
    {
        public string CurrencyCode { get; set; }

        public decimal? DesadvTotal { get => desadvTotal ?? desadvTaxableTotal; set => desadvTotal = value; }
        public decimal? DesadvTotalWithVAT { get; set; }
        public decimal? DesadvTotalVAT { get; set; }
        public decimal? DesadvTaxableTotal { get => desadvTaxableTotal ?? desadvTotal; set => desadvTaxableTotal = value; }

        public DocumentRevisionType DocumentRevisionType { get; set; }
        public CommonGoodItem[] GoodItems { get; set; }

        public string AnnouncementForReturnsNumber { get; set; }
        public DateTime? AnnouncementForReturnsDate { get; set; }

        public string InstructionsForReturnsNumber { get; set; }
        public DateTime? InstructionsForReturnsDate { get; set; }

        public string ReturnDeliveryNoteNumber { get; set; }
        public DateTime? ReturnDeliveryNoteDate { get; set; }

        public string ReturnInvoiceNumber { get; set; }
        public DateTime? ReturnInvoiceDate { get; set; }

        private decimal? desadvTotal;
        private decimal? desadvTaxableTotal;
    }
}