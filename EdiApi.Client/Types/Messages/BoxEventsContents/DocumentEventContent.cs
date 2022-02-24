using SkbKontur.EdiApi.Client.Types.BoxEvents;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    public abstract class DocumentEventContent : IBoxEventContent
    {
        /// <summary>Идентификатор документа в ящике</summary>
        public DocumentId DocumentId { get; set; }

        /// <summary>Внутренний идентификатор сообщения (при помощи этого идентификатора можно просмотреть информацию о сообщении в мониторинге сервиса)</summary>
        public string DocumentCirculationId { get; set; }
    }
}