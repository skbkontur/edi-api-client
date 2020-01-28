using SkbKontur.EdiApi.Types.BoxEvents;

namespace SkbKontur.EdiApi.Types.Messages.BoxEventsContents
{
    public abstract class DocumentEventContent : IBoxEventContent
    {
        public DocumentId DocumentId { get; set; }
        public string DocumentCirculationId { get; set; }
    }
}