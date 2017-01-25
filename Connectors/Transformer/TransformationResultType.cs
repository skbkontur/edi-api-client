namespace KonturEdi.Api.Types.Connectors.Transformer
{
    public enum TransformationResultType 
    {
        TransformedSuccessfully,
        TransformedUnsuccessfully,
        RecognizedAsServiceMessage,
        FinishedWithoutTransformation,
    }
}
