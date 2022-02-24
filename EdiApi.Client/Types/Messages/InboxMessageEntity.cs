using SkbKontur.EdiApi.Client.Types.Common;

namespace SkbKontur.EdiApi.Client.Types.Messages
{
    /// <summary>Входящее сообщение</summary>
    public class InboxMessageEntity
    {
        /// <summary>Метаинформация сообщения</summary>
        public InboxMessageMeta Meta { get; set; }

        /// <summary>Данные сообщения</summary>
        public MessageData Data { get; set; }
    }
}