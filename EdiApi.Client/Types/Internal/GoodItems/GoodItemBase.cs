namespace SkbKontur.EdiApi.Client.Types.Internal.GoodItems
{
    public class GoodItemBase
    {
        public string LineItemIdentifier { get; set; }

        public string GTIN { get; set; }

        public string BuyerProductId { get; set; }

        public string SupplierProductId { get; set; }

        public string AdditionalId { get; set; }

        public string SerialNumber { get; set; }

        public string ForeignTradeCode { get; set; }
    }
}