using JetBrains.Annotations;

using KonturEdi.Api.Types.Common;

namespace KonturEdi.Api.Types.Connectors.Transformer
{
    public class ConnectorTransformationResult
    {
        private ConnectorTransformationResult(TransformationResultType type, [CanBeNull] MessageData messageData, [CanBeNull] string[] errors, [CanBeNull] ConnectorServiceMessageData serviceMessageData)
        {
            TransformationResultType = type;
            MessageData = messageData;
            Errors = errors;
            ServiceMessageData = serviceMessageData;
        }

        [NotNull]
        public static ConnectorTransformationResult ForSuccessfullyTransformed([NotNull] MessageData messageData)
        {
            return new ConnectorTransformationResult(TransformationResultType.SuccessfullyTransformed, messageData, null, null);
        }

        [NotNull]
        public static ConnectorTransformationResult ForUnsuccessfullyTransformed([CanBeNull] string[] errors)
        {
            return new ConnectorTransformationResult(TransformationResultType.UnsuccessfullyTransformed, null, errors, null);
        }

        [NotNull]
        public static ConnectorTransformationResult ForServiceMessage([NotNull] ConnectorServiceMessageData serviceMessageData)
        {
            return new ConnectorTransformationResult(TransformationResultType.SuccessfullyTransformedForServiceMessage, null, null, serviceMessageData);
        }

        public static ConnectorTransformationResult ForFinishedWithoutTransformation()
        {
            return new ConnectorTransformationResult(TransformationResultType.FinishedWithoutTransformation, null, null, null);
        }

        public TransformationResultType TransformationResultType { get; private set; }

        [CanBeNull]
        public MessageData MessageData { get; private set; }

        [CanBeNull]
        public string[] Errors { get; private set; }

        [CanBeNull]
        public ConnectorServiceMessageData ServiceMessageData { get; private set; }
    }
}
