#nullable enable

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Создатель универсального сообщения Диадока</summary>
    public class DiadocUniversalMessageCreator
    {
        /// <summary>Идентификатор ящика</summary>
        public string BoxId { get; set; } = null!;
    }
}