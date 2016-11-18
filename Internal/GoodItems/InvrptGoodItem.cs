using SKBKontur.Catalogue.EDI.MessagesFormats.References;

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
        [ReferenceCode("ActualStock")]
        ActualStock,

        [ReferenceCode("OrderedQuantity")]
        OrderedQuantity,

        [ReferenceCode("DeliveredQuantity")]
        DeliveredQuantity,

        [ReferenceCode("ReceivedQuantity")]
        ReceivedQuantity
    }
}