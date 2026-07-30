#nullable enable

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    /// <summary>Информация о событии InboxDiadocUniversalMessage в ящике получателя</summary>
    public class InboxDiadocUniversalMessageEventContent : InboxDiadocEventContentBase
    {
        /// <summary>Информация об универсальном сообщении</summary>
        public DiadocUniversalMessageInfo UniversalMessage { get; set; } = null!;
    }
}