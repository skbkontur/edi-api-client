#nullable enable

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии AmendmentRequested</summary>
    public class AmendmentRequestedEventContent : OutboxDiadocEventContentBase
    {
        /// <summary>Текст уведомления об уточнении</summary>
        public string? AmendmentRequestMessage { get; set; }
    }
}