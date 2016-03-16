using KonturEdi.Api.Types.BoxEvents;

namespace KonturEdi.Api.Types.Internal.BoxEventsContents
{
    public abstract class DocumentEventContent : IBoxEventContent
    {
        private DocumentId DocumentId { get; set; }
        public string DocumentCirculationId { get; set; }

        public bool IsEmpty()
        {
            return DocumentId == null;
        }
    }
}