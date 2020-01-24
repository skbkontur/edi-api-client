using SkbKontur.EdiApi.Types.BoxEvents;

namespace SkbKontur.EdiApi.Types.Messages.BoxEventsContents.Outbox
{
    public abstract class OutboxDiadocEventContentBase : DiadocEventContentBase, IBoxEventContent
    {
        public BasicMessageMeta OutboxMessageMeta { get; set; }
    }
}