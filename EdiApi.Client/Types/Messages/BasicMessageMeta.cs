﻿namespace SkbKontur.EdiApi.Client.Types.Messages
{
    /// <summary>Метаинформация сообщения</summary>
    public class BasicMessageMeta
    {
        /// <summary>Идентификатор ящика, в который было доставлено сообщение</summary>
        public string BoxId { get; set; }

        /// <summary>Идентификатор сообщения</summary>
        public string MessageId { get; set; }

        /// <summary>Внутренний идентификатор сообщения: при помощи этого идентификатора можно просмотреть информацию о сообщении в мониторинге сервиса</summary>
        public string DocumentCirculationId { get; set; }
    }
}