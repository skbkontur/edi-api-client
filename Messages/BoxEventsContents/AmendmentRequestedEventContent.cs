using KonturEdi.Api.Types.BoxEvents;

namespace KonturEdi.Api.Types.Messages.BoxEventsContents
{
    public class AmendmentRequestedEventContent : DiadocEventContentBase, IBoxEventContent
    {
        public BasicMessageMeta MessageMeta { get; set; }

        public string AmendmentRequestMessage { get; set; }
    }
}