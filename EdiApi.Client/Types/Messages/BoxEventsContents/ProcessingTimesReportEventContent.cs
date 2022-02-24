using System;

using SkbKontur.EdiApi.Client.Types.BoxEvents;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Информация о событии ProcessingTimesReport</summary>
    public class ProcessingTimesReportEventContent : IBoxEventContent
    {
        /// <summary>Внутренний идентификатор сообщения: при помощи этого идентификатора можно просмотреть информацию о сообщении в мониторинге сервиса</summary>
        public string DocumentCirculationId { get; set; }

        /// <summary>Идентификатор организации - отправителя</summary>
        public string SenderPartyId { get; set; }

        /// <summary>Идентификатор организации - получателя</summary>
        public string RecipientPartyId { get; set; }

        /// <summary>Идентификатор сообщения</summary>
        public string InitialMessageId { get; set; }

        /// <summary>Идентификатор документа в ящике</summary>
        public DocumentId InitialDocumentId { get; set; }

        /// <summary>Тип сообщения</summary>
        public DocumentType DocumentType { get; set; }

        /// <summary>Дата и время начала документооборота</summary>
        public DateTime DocumentCirculationStartTimestamp { get; set; }

        /// <summary>Дата и время завершения документооборота</summary>
        public DateTime DocumentCirculationCompletionTimestamp { get; set; }

        /// <summary>Время, затраченное на различные этапы обработки сообщения, и общее время доставки сообщения</summary>
        public ProcessingTimes ProcessingTimes { get; set; }
    }
}