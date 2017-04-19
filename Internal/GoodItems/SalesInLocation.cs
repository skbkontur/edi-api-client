namespace KonturEdi.Api.Types.Internal.GoodItems
{
    public class SalesInLocation
    {
        public string Gln { get; set; }
        public SlsrptGoodItem[] GoodItems { get; set; }
    }

    public class SlsrptGoodItem : GoodItemBase
    {
        public string Name { get; set; }

        public Quantity SalesQuantity { get; set; }

        public Quantity ReturnQuantity { get; set; }

        public decimal? Price { get; set; }
        public decimal? PriceWithVAT { get; set; }
        public decimal? PriceSummary { get; set; }
        public decimal? PriceSummaryWithVAT { get; set; }
        public string VATRate { get; set; }
        public decimal? ExciseTax { get; set; }
        public decimal? VATSummary { get; set; }
    }
}