#nullable enable

using SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Создатель универсального сообщения Диадока</summary>
    public class DiadocUniversalMessageCreator
    {
        /// <summary>Идентификатор ящика</summary>
        public string BoxId { get; set; } = null!;

        /// <summary>Вычисленная роль создателя универсального сообщения в контексте документа</summary>
        public DiadocDocumentParticipantRole DocumentParticipantRole { get; set; }
    }
}