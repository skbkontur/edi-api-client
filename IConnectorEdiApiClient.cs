using KonturEdi.Api.Types.Common;
using KonturEdi.Api.Types.Connectors;

namespace KonturEdi.Api.Client
{
    public interface IConnectorEdiApiClient : IBaseEdiApiClient
    {
        MessageEntity GetMessage(string authToken, string boxId, string messageId);
        ConnectorBoxesInfo GetConnectorBoxesInfo(string authToken);
    }
}