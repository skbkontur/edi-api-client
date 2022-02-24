using System;

namespace SkbKontur.EdiApi.Client.Types.Messages
{
    /// <summary>Результат доставки сообщения</summary>
    public class MessageDeliveryResult
    {
        /// <summary>Дата и время доставки</summary>
        public DateTime? DeliveryTimestamp { get; set; }

        /// <summary>Ошибка доставки сообщения</summary>
        //[CanBeNull]
        public string DeliveryError { get; set; }

        /// <summary>Дата и время первой попытки доставить сообщение</summary>
        public DateTime FirstDeliveryAttemptTimestamp { get; set; }
    }
}