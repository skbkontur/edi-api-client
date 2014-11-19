using KonturEdi.Api.Types.BoxEvents;

namespace KonturEdi.Api.Types.Connectors.Transformer
{
    public class TransformerConnectorBoxEvent : BoxEvent<TransformerConnectorBoxEventType>
    {
    }

    public class TransformerConnectorBoxEvent<TEventContent> : BoxEvent<TransformerConnectorBoxEventType, TEventContent>
        where TEventContent : IBoxEventContent
    {
    }

    public class TransformerConnectorBoxEventBatch : BoxEventBatch<TransformerConnectorBoxEventType, TransformerConnectorBoxEvent>
    {
    }
}