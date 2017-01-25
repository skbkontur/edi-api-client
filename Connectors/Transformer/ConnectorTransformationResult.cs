using KonturEdi.Api.Types.Common;

namespace KonturEdi.Api.Types.Connectors.Transformer
{
    public class ConnectorTransformationResult
    {
        public TransformationResultType TransformationResultType { get; set; }

        public MessageData MessageData { get; set; }

        public string[] Errors { get; set; }

        public ConnectorServiceMessageData ConnectorServiceMessageData { get; set; }
    }
}
