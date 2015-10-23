namespace KonturEdi.Api.Types.Messages
{
    public class OutboxMessageMeta
    {
        public string BoxId { get; set; }
        public string MessageId { get; set; }
        public string DocumentCirculationId { get; set; }
    }
}