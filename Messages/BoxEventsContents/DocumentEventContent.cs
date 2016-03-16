using KonturEdi.Api.Types.BoxEvents;

namespace KonturEdi.Api.Types.Messages.BoxEventsContents
{
    public abstract class DocumentEventContent : IBoxEventContent
    {
        public DocumentId DocumentId { get; set; }
        public string DocumentCirculationId { get; set; }

        public bool IsEmpty()
        {
            return DocumentId == null;
        }
    }

    public class DocumentId
    {
        public string BoxId { get; set; }
        public string EntityId { get; set; }
    }
}