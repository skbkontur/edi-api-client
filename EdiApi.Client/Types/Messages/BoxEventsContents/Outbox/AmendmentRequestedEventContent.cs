#nullable enable

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии AmendmentRequested</summary>
    public class AmendmentRequestedEventContent : OutboxDiadocEventContentBase
    {
        /// <summary>Текст уведомления об уточнении</summary>
        public string? AmendmentRequestMessage { get; set; }

        /// <summary>
        ///     Требуется подписать документ отмены фиксации в ГИС МТ "Честный ЗНАК".
        ///     Значение поля актуально на момент возникновения события и не меняется после подписания документа отмены фиксации.
        /// </summary>
        public bool? IsGisMtFixationCancellationSigningRequired { get; set; }
    }
}