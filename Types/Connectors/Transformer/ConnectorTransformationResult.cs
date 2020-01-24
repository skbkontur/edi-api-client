using SkbKontur.EdiApi.Types.Common;

namespace SkbKontur.EdiApi.Types.Connectors.Transformer
{
    public class ConnectorTransformationResult
    {
        public TransformationResultType TransformationResultType { get; set; }
        public string[] Errors { get; set; }
        public MessageData MessageData { get; set; }
        public ServiceMessageData ServiceMessageData { get; set; }
    }
}