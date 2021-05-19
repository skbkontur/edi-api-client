using System.Collections.Generic;

using SkbKontur.EdiApi.Client.Types.Messages;
using SkbKontur.EdiApi.Client.Types.Parties;

#nullable enable

namespace SkbKontur.EdiApi.Client.Types.Internal
{
    public class EditablePartySettings
    {
        public EditablePartyInfo PartyInfo { get; set; } = default!;

        public EditableDeliverySettings DeliverySettings { get; set; } = default!;

        public EditableConnectorSettings? ConnectorSettings { get; set; }

        public EditableWebInterfaceSettings? WebInterfaceSettings { get; set; }
    }

    public class EditableDeliverySettings
    {
        public bool UseTestBoxes { get; set; }

        public EditableApiSettings? ApiBoxSettings { get; set; }

        public string XmlEncoding { get; set; } = default!;

        public MessageFormat MessageFormat { get; set; }
        public MessageFormat StatusMessageFormat { get; set; }
    }

    public class EditableApiSettings
    {
        public bool DeliveryNotificationEnabled { get; set; }
    }

    public class EditableConnectorSettings
    {
        public EditableConnectorSettings() => InboxByDocTypeBoxes = new List<EditableConnectorBoxForDocType>();

        public EditableConnectorBox? AllOutboxBox { get; set; }

        public EditableConnectorBox? AllInboxBox { get; set; }

        public List<EditableConnectorBoxForDocType> InboxByDocTypeBoxes { get; set; }
    }

    public class EditableConnectorBox
    {
        public string Id { get; set; } = default!;

        public string Name { get; set; } = default!;
    }

    public class EditableConnectorBoxForDocType
    {
        public DocumentType DocumentType { get; set; }

        public EditableConnectorBox Box { get; set; } = default!;
    }

    public class EditablePartyInfo
    {
        public PartyType PartyType { get; set; }

        public string Gln { get; set; } = default!;

        public string Name { get; set; } = default!;

        public string Inn { get; set; } = default!;

        public string Kpp { get; set; } = default!;

        public string? BillingAccountId { get; set; }

        public bool CreateNewBillingAccount { get; set; }
    }

    public class EditableTradingPartnersSettings
    {
        public string BuyerId { get; set; } = default!;

        public string SupplierId { get; set; } = default!;

        public string? BuyerRoamingProviderId { get; set; }

        public string? SupplierRoamingProviderId { get; set; }

        public DocumentType[] UsedMessages { get; set; } = default!;
    }

    public class EditableWebInterfaceSettings
    {
        public WebInterfaceKind DefaultWebInterface { get; set; }
    }

    public enum WebInterfaceKind
    {
        Monitoring,
        SupplierInterface
    }
}