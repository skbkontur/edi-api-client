using KonturEdi.Api.Types.BoxEvents;

namespace KonturEdi.Api.Types.Messages.BoxEventsContents
{
    public abstract class DocumentEventContent : IBoxEventContent
    {
        public DocumentId DocumentId { get; set; }
        public string DocumentCirculationId { get; set; }
    }
}