using SkbKontur.EdiApi.Client.Types.BoxEvents;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    public abstract class OutboxDiadocEventContentBase : DiadocEventContentBase, IBoxEventContent
    {
        public BasicMessageMeta OutboxMessageMeta { get; set; }
    }
}