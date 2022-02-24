using System;

namespace SkbKontur.EdiApi.Client.Types.Messages
{
    /// <summary>Метаинформация входящего сообщения</summary>
    public class InboxMessageMeta : BasicMessageMeta
    {
        /// <summary>Дата и время отправки сообщения контрагентом</summary>
        public DateTime SendDateTime { get; set; }

        /// <summary>Организация - отправитель сообщения</summary>
        public Partner Sender { get; set; }

        /// <summary>Формат сообщения</summary>
        public MessageFormat MessageFormat { get; set; }

        /// <summary>Информация о документе</summary>
        public DocumentDetails DocumentDetails { get; set; }
    }
}