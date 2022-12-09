﻿namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    /// <summary>Информация о событии InboxDiadocRevocationGisMtStatusChanged в ящике получателя</summary>
    public class InboxDiadocDocumentRevocationGisMtStatusChanged : InboxDiadocEventContentBase
    {
        /// <summary>Информация о статусе проверки в ГИС МТ "Честный знак"</summary>
        public DiadocGisMtInfo DiadocGisMtInfo { get; set; }
    }
}