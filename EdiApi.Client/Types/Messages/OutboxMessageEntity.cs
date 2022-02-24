using SkbKontur.EdiApi.Client.Types.Common;

namespace SkbKontur.EdiApi.Client.Types.Messages
{
    /// <summary>Исходящее сообщение</summary>
    public class OutboxMessageEntity
    {
        /// <summary>Метаинформация сообщения</summary>
        public OutboxMessageMeta Meta { get; set; }

        /// <summary>Данные сообщения</summary>
        public MessageData Data { get; set; }
    }
}