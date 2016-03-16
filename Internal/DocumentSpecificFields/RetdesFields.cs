using KonturEdi.Api.Types.Internal.GoodItems;

namespace KonturEdi.Api.Types.Internal.DocumentSpecificFields
{
    public class RetdesFields : OrderBasedDocumentFields
    {
        public string CurrencyCode { get; set; }

        public decimal? DesadvTotal { get { return desadvTotal ?? desadvTaxableTotal; } set { desadvTotal = value; } }
        public decimal? DesadvTotalWithVAT { get; set; }
        public decimal? DesadvTotalVAT { get; set; }
        public decimal? DesadvTaxableTotal { get { return desadvTaxableTotal ?? desadvTotal; } set { desadvTaxableTotal = value; } }

        public DocumentRevisionType DocumentRevisionType { get; set; }
        public CommonGoodItem[] GoodItems { get; set; }

        private decimal? desadvTotal;
        private decimal? desadvTaxableTotal;
    }
}