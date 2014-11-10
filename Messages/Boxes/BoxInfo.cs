namespace KonturEdi.Api.Types.Messages.Boxes
{
    public class BoxInfo
    {
        public string Id { get; set; }
        public string PartyId { get; set; }
        public BoxSettings BoxSettings { get; set; }
    }
}