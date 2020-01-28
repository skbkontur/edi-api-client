namespace SkbKontur.EdiApi.Types.Internal.GoodItems
{
    public class InvrptGoodItem : GoodItemBase
    {
        public string Name { get; set; }

        public InventoryItem[] InventoryItems { get; set; }
    }

    public class InventoryItem
    {
        public string LocationOfGoods { get; set; }
        public InventoryQuantity[] InventoryQuantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceWithVAT { get; set; }
    }

    public class InventoryQuantity
    {
        public Quantity Quantity { get; set; }
        public QuantityType QuantityType { get; set; }
    }

    public enum QuantityType
    {
        ActualStock,
        OrderedQuantity,
        DeliveredQuantity,
        ReceivedQuantity,
        OpeningStock,
        ClosingStock,
        SalesQuantity
    }
}