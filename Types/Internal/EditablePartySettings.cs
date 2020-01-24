using System.Collections.Generic;

using JetBrains.Annotations;

using KonturEdi.Api.Types.Messages;
using KonturEdi.Api.Types.Parties;

namespace KonturEdi.Api.Types.Internal
{
    public class EditablePartySettings
    {
        [NotNull]
        public EditablePartyInfo PartyInfo { get; set; }

        [CanBeNull]
        public EditableBillingSettings BillingSettings { get; set; }

        [CanBeNull]
        public EditableConnectorSettings ConnectorSettings { get; set; }

        [NotNull]
        public EditableDeliverySettings DeliverySettings { get; set; }
    }

    public class EditableBillingSettings
    {
        [NotNull]
        public string BillingId { get; set; }
    }

    public class EditableDeliverySettings
    {
        [CanBeNull]
        public EditableApiSettings ApiBoxSettings { get; set; }

        [NotNull]
        public string XmlEncoding { get; set; }

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

        [CanBeNull]
        public EditableConnectorBox AllOutboxBox { get; set; }

        [CanBeNull]
        public EditableConnectorBox AllInboxBox { get; set; }

        [ItemNotNull]
        public List<EditableConnectorBoxForDocType> InboxByDocTypeBoxes { get; set; }
    }

    public class EditableConnectorBox
    {
        [NotNull]
        public string Id { get; set; }

        [NotNull]
        public string Name { get; set; }
    }

    public class EditableConnectorBoxForDocType
    {
        public DocumentType DocumentType { get; set; }

        [NotNull]
        public EditableConnectorBox Box { get; set; }
    }

    public class EditablePartyInfo
    {
        [NotNull]
        public string Gln { get; set; }

        [NotNull]
        public string Name { get; set; }

        public PartyType PartyType { get; set; }

        [NotNull]
        public string Inn { get; set; }

        [NotNull]
        public string Kpp { get; set; }
    }

    public class EditableTradingPartnersSettings
    {
        [NotNull]
        public string BuyerId { get; set; }

        [NotNull]
        public string SupplierId { get; set; }

        [CanBeNull]
        public string BuyerRoamingProviderId { get; set; }

        [CanBeNull]
        public string SupplierRoamingProviderId { get; set; }

        [NotNull]
        public DocumentType[] UsedMessages { get; set; }
    }
}