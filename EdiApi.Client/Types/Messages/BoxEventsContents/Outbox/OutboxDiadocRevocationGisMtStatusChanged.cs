﻿namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии OutboxDiadocRevocationGisMtStatusChanged в ящике отправителя</summary>
    public class OutboxDiadocRevocationGisMtStatusChanged : OutboxDiadocEventContentBase
    {
        /// <summary>Статус в ГИС МТ "Честный знак"</summary>
        public GisMtStatus GisMtStatus { get; set; }

        /// <summary>Список ошибок, которые были получены при взаимодействии с ГИС МТ Честный знак в рамках документооборота</summary>
        public DiadocGisMtStatusDetail[] Details { get; set; }
    }
}