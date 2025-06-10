namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии DiadocRevocationAccepted</summary>
    public class MessageDiadocRevocationAcceptedEventContent : OutboxDiadocEventContentBase
    {
        /// <summary>Информация об аннулированном документе</summary>
        public RevocationInfo AcceptedRevocationInfo { get; set; }

        /// <summary>
        ///     Требуется подписать документ отмены фиксации в ГИС МТ "Честный ЗНАК".
        ///     Значение поля актуально на момент возникновения события и не меняется после подписания документа отмены фиксации.
        /// </summary>
        public bool? IsGisMtFixationCancellationSigningRequired { get; set; }
    }
}