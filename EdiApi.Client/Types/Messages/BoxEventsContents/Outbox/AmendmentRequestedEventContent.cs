#nullable enable

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии AmendmentRequested</summary>
    public class AmendmentRequestedEventContent : OutboxDiadocEventContentBase
    {
        /// <summary>Текст уведомления об уточнении</summary>
        public string? AmendmentRequestMessage { get; set; }

        /// <summary>
        ///     Требуется подписать документ отмены фиксации кодов в ГИС МТ "Честный ЗНАК".
        ///     Значение поля актуально на момент возникновения события и не меняется после подписания документа отмены фиксации кодов.
        /// </summary>
        public bool? IsGisMtFixationCancellationSigningRequired { get; set; }
    }
}