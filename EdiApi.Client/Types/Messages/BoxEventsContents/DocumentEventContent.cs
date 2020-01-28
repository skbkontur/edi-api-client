using SkbKontur.EdiApi.Client.Types.BoxEvents;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    public abstract class DocumentEventContent : IBoxEventContent
    {
        public DocumentId DocumentId { get; set; }
        public string DocumentCirculationId { get; set; }
    }
}