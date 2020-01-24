namespace SkbKontur.EdiApi.Types.Connectors.Transformer
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