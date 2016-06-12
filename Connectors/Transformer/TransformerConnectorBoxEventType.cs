namespace KonturEdi.Api.Types.Connectors.Transformer
{
    public enum TransformerConnectorBoxEventType
    {
        Unknown,

        NewMessageForTransformation,
        ConnectorTakenToTransformation,
        ConnectorTransformationDelayed,
        ConnectorTransformedSuccessfully,
        ConnectorTransformedUnsuccessfully,
    }
}