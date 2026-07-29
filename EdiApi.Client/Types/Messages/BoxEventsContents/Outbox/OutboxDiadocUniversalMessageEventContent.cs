#nullable enable

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии OutboxDiadocUniversalMessage в ящике отправителя</summary>
    public class OutboxDiadocUniversalMessageEventContent : OutboxDiadocEventContentBase
    {
        /// <summary>Информация об универсальном сообщении</summary>
        public DiadocUniversalMessageEventInfo UniversalMessage { get; set; } = null!;
    }
}