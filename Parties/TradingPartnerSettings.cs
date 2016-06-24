using KonturEdi.Api.Types.Messages;

namespace KonturEdi.Api.Types.Parties
{
    public class TradingPartnerSettings
    {
        public string PartnerPartyId { get; set; }
        public ConcretePartyRole PartnerPartyRole { get; set; }
        public string OwnProviderId { get; set; }
        public string PartnerProviderId { get; set; }
        public TrafficType TrafficType { get; set; }
        public DocumentSettings[] UsedDocumentTypes { get; set; }
    }
}