namespace SkbKontur.EdiApi.Client.Types.Internal.GoodItems
{
    public class OrdrspGoodItem : CommonGoodItem
    {
        public OrdrspGoodItemStatus? OrdrspGoodItemStatus { get; set; }
    }

    public enum OrdrspGoodItemStatus
    {
        Changed,
        Accepted,
        Rejected,
        Unknown
    }
}