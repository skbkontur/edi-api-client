namespace KonturEdi.Api.Types.Internal.GoodItems
{
    public class GoodNumber
    {
        public Message Message { get; set; }
        public int Number { get; set; }
    }

    public enum Message
    {
        POrders = 0,
        Orders = 1,
        Ordrsp = 2,
        Desadv = 3,
        Recadv = 4,
        Invoic = 5,
        Retann = 6,
        Coinvoic = 7,
        Alcrpt = 8,
        Retdes = 9,
        Retrec = 10,
        Junk = 11
    }
}