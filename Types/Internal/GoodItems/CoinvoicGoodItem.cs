namespace SkbKontur.EdiApi.Types.Internal.GoodItems
{
    public class CoinvoicGoodItem : GoodItemBase
    {
        public string[] CountriesOfOriginCode { get; set; }
        public decimal? PriceWithVAT { get; set; }
        public string[] CustomDeclarationNumbers { get; set; }
        public Quantity OnePlaceQuantity { get; set; }
        public CoinvoicBeforeAfter<Quantity> InvoicedQuantity { get; set; }
        public CoinvoicBeforeAfter<decimal?> PriceSummary { get; set; }
        public CoinvoicBeforeAfter<decimal?> PriceSummaryWithVAT { get; set; }
        public CoinvoicBeforeAfter<decimal?> ExciseTax { get; set; }
        public CoinvoicBeforeAfter<decimal?> Price { get; set; }
        public CoinvoicBeforeAfter<string> VATRate { get; set; }
        public CoinvoicBeforeAfter<decimal?> VATSummary { get; set; }
        public GoodItemAdditionalInfo AdditionalInfo { get; set; }
    }

    public class CoinvoicBeforeAfter<T>
    {
        public T Before { get; set; }
        public T After { get; set; }
        public T Increase { get; set; }
        public T Decrease { get; set; }
    }
}