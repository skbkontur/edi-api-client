namespace SkbKontur.EdiApi.Client.Types.Connectors.Transformer
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