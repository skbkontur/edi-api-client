using System;

using SkbKontur.EdiApi.Types.Internal.GoodItems;

namespace SkbKontur.EdiApi.Types.Internal.DocumentSpecificFields
{
    public class RetrecFields : OrderBasedDocumentFields
    {
        public DateTime? AcceptanceDate { get; set; }

        public string FreeText { get; set; }

        public string DespatchAdviceNumber { get; set; }
        public DateTime? DespatchDate { get; set; }

        public string CurrencyCode { get; set; }

        public decimal? RecadvTotal { get; set; }
        public decimal? RecadvTaxableTotal { get; set; }
        public decimal? RecadvTotalWithVAT { get; set; }
        public decimal? RecadvTotalVAT { get; set; }

        public DocumentRevisionType? DocumentRevisionType { get; set; }
        public CommonGoodItem[] GoodItems { get; set; }

        public string AnnouncementForReturnsNumber { get; set; }
        public DateTime? AnnouncementForReturnsDate { get; set; }

        public string ReturnDeliveryNoteNumber { get; set; }
        public DateTime? ReturnDeliveryNoteDate { get; set; }
    }
}