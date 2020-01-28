namespace SkbKontur.EdiApi.Client.Types.Connectors.Transformer
{
    public enum TransformationResultType
    {
        Failure = 0,
        SuccessWithTransformation = 1,
        SuccessWithNoTransformation = 2,
        SuccessForServiceMessage = 3,
    }
}