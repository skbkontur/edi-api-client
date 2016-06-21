using System.Collections.Generic;

using KonturEdi.Api.Types.Messages;

namespace KonturEdi.Api.Types.Parties
{
    public class InternalPartyInfo : PartyInfo
    {
        public string ProviderId { get; set; }
        public PartnerSettings[] TradingPartnerSettings { get; set; }
    }

    public class PartnerSettings
    {
        public string PartnerPartyId { get;set; }
        public ConcretePartyRole PartnerPartyRole { get; set; }
        public string OwnProviderId { get; set; }
        public string PartnerProviderId { get; set; }
        public TrafficType TrafficType { get; set; }
        public DocumentSettings[] UsedDocumentTypes { get; set; }
    }

    public enum ConcretePartyRole
    {
        Supplier,
        Buyer
    }

    public enum TrafficType
    {
        Test,
        Production
    }
}