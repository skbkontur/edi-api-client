namespace KonturEdi.Api.Types.Internal.GoodItems
{
    public class InvrptGoodItem : GoodItemBase
    {
        public string Name { get; set; }

        public InventoryItem[] InventoryItems { get; set; }
    }

    public class InventoryItem
    {
        public string LocationOfGoods { get; set; }

        public Quantity ActualStock { get; set; }
        public Quantity OrderedQuantity { get; set; }
        public Quantity DeliveredQuantity { get; set; }
        public Quantity ReceivedQuantity { get; set; }

        public decimal? Price { get; set; }
        public decimal? PriceWithVat { get; set; }
    }
}