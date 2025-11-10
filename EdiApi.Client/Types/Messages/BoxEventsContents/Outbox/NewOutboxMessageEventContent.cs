#nullable enable
using SkbKontur.EdiApi.Client.Types.Boxes;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии NewOutboxMessage</summary>
    public class NewOutboxMessageEventContent : OutboxEventContentBase
    {
        /// <summary>Тип транспорта</summary>
        public TransportType TransportType { get; set; }

        /// <summary>
        ///     Внутренний идентификатор родительского документа
        ///     (архива/мультисообщения/изначального сообщения при переотправке)
        /// </summary>
        public string? ParentDocumentCirculationId { get; set; }

        /// <summary>
        ///     Имя файла сообщения
        /// </summary>
        public string? MessageFileName { get; set; }
    }
}