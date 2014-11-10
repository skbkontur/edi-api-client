using KonturEdi.Api.Types.BoxEvents;

namespace KonturEdi.Api.Types.Messages.BoxEvents
{
    public class MessageBoxEvent : BoxEvent<MessageBoxEventType>
    {
    }

    public class MessageBoxEvent<TEventContent> : BoxEvent<MessageBoxEventType, TEventContent>
        where TEventContent : IBoxEventContent
    {
    }
}