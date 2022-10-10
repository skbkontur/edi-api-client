using SkbKontur.EdiApi.Client.Types.Messages;

namespace SkbKontur.EdiApi.Client.Types.Parties
{
    public class TradingPartnerSettings
    {
        public string PartnerPartyId { get; set; }
        public ConcretePartyRole? PartnerPartyRole { get; set; }
        public string OwnProviderPartyId { get; set; }
        public string PartnerProviderPartyId { get; set; }
        public TrafficType TrafficType { get; set; }
        public DocumentSettings[] UsedDocumentTypes { get; set; }
    }
}