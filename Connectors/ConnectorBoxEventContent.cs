using System;

using KonturEdi.Api.Types.BoxEvents;

namespace KonturEdi.Api.Types.Connectors
{
    public abstract class ConnectorBoxEventContent : IBoxEventContent
    {
        public string ConnectorInteractionId { get; set; }
        public string DocumentCirculationId { get; set; }
        
        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }
    }
}