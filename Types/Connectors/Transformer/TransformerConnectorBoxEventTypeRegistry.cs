using SkbKontur.EdiApi.Types.BoxEvents;
using SkbKontur.EdiApi.Types.Connectors.Transformer.EventContents;

namespace SkbKontur.EdiApi.Types.Connectors.Transformer
{
    public class TransformerConnectorBoxEventTypeRegistry : BoxEventTypeRegistry<TransformerConnectorBoxEventType>
    {
        public TransformerConnectorBoxEventTypeRegistry()
        {
            Register<NewMessageForTransformationEventContent>(TransformerConnectorBoxEventType.NewMessageForTransformation);
            Register<TakenToTransformationEventContent>(TransformerConnectorBoxEventType.ConnectorTakenToTransformation);
            Register<TransformationPausedEventContent>(TransformerConnectorBoxEventType.ConnectorTransformationPaused);
            Register<TransformationResumedEventContent>(TransformerConnectorBoxEventType.ConnectorTransformationResumed);
            Register<TransformedSuccessfullyEventContent>(TransformerConnectorBoxEventType.ConnectorTransformedSuccessfully);
            Register<TransformedUnsuccessfullyEventContent>(TransformerConnectorBoxEventType.ConnectorTransformedUnsuccessfully);
        }
    }
}