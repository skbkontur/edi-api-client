namespace KonturEdi.Api.Types.Connectors.Transformer
{
    public enum TransformerConnectorBoxEventType
    {
        Unknown,

        NewMessageForTransformation,
        ConnectorTakenToTransformation,
        ConnectorTransformationPaused,
        ConnectorTransformationResumed,
        ConnectorTransformedSuccessfully,
        ConnectorTransformedUnsuccessfully,
    }
}