namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии DiadocRevocationRequested</summary>
    public class MessageDiadocRevocationRequestedEventContent : OutboxDiadocEventContentBase
    {
        /// <summary>Информация об аннулировании документа</summary>
        public RevocationInfo RevocationInfo { get; set; }

        /// <summary>
        ///     Требуется подписать документ отмены фиксации в ГИС МТ "Честный ЗНАК".
        ///     Значение поля актуально на момент возникновения события и не меняется после подписания документа отмены фиксации.
        /// </summary>
        public bool? IsGisMtFixationCancellationSigningRequired { get; set; }
    }
}