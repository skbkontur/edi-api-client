﻿namespace KonturEdi.Api.Types.Connectors.Transformer
{
    public enum TransformationResultType 
    {
        TransformedSuccessfully,
        TransformationFailed,
        RecognizedAsServiceMessage,
        FinishedWithoutTransformation,
    }
}
