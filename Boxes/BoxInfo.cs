namespace KonturEdi.Api.Types.Boxes
{
    public class BoxInfo
    {
        public string Id { get; set; }
        public string PartyId { get; set; }
        public string Gln { get; set; }
        public bool IsTest { get; set; }
        public BoxSettings BoxSettings { get; set; }
    }
}