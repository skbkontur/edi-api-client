#nullable enable

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Событие в истории универсального сообщения Диадока</summary>
    public class DiadocUniversalMessageEvent
    {
        /// <summary>Числовой код события</summary>
        public int StatusCode { get; set; }

        /// <summary>Текст события</summary>
        public string? PlainText { get; set; }
    }
}