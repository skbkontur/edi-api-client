namespace SkbKontur.EdiApi.Client.Types.Messages.DirectSending
{
    public class AS2SendDetails
    {
        public string MessageId { get; set; }

        public byte[] Mdn { get; set; }
        public bool IsMdnPositive { get; set; }
    }
}