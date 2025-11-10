#nullable enable
using SkbKontur.EdiApi.Client.Types.Boxes;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии NewOutboxMessage</summary>
    public class NewOutboxMessageEventContent : OutboxEventContentBase
    {
        /// <summary>Тип транспорта</summary>
        public TransportType TransportType { get; set; }

        /// <summary>Внутренний идентификатор родительского сообщения — архива, мультисообщения, или изначального сообщения при переотправке из мониторинга</summary>
        public string? ParentDocumentCirculationId { get; set; }

        /// <summary>Имя файла сообщения. Заполняется при распаковке сообщения из архива, мультисообщения и при переотправке сообщения из мониторинга</summary>
        public string? MessageFileName { get; set; }
    }
}