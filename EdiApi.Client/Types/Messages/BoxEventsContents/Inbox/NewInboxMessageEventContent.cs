using SkbKontur.EdiApi.Client.Types.BoxEvents;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    /// <summary>Информация о событии NewInboxMessage</summary>
    public class NewInboxMessageEventContent : IBoxEventContent
    {
        /// <summary>Метаинформация сообщения</summary>
        public InboxMessageMeta InboxMessageMeta { get; set; }
    }
}