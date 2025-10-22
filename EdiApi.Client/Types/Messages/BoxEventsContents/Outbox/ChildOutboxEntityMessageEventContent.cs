using SkbKontur.EdiApi.Client.Types.Boxes;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии ChildOutboxEntityMessage</summary>
    public class ChildOutboxEntityMessageEventContent : OutboxEventContentBase
    {
        /// <summary>Тип транспорта</summary>
        public TransportType TransportType { get; set; }

        /// <summary>Внутренний идентификатор родительского документа (архива/мультисообщения)</summary>
        public string ParentDocumentCirculationId { get; set; }

        /// <summary>Имя исходного файла, из которого было создано сообщение</summary>
        public string SourceFileName { get; set; }
    }
}