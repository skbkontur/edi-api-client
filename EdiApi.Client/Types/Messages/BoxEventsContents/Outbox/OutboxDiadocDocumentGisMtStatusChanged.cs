﻿namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии OutboxDiadocDocumentGisMtStatusChanged в ящике отправителя</summary>
    public class OutboxDiadocDocumentGisMtStatusChanged : OutboxDiadocEventContentBase
    {
        /// <summary>Информация о статусе проверки в ГИС МТ "Честный ЗНАК"</summary>
        public DiadocGisMtInfo DiadocGisMtInfo { get; set; }
    }
}