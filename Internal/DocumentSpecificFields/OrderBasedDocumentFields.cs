using System;

using KonturEdi.Api.Types.Organization;

namespace KonturEdi.Api.Types.Internal.DocumentSpecificFields
{
    public abstract class OrderBasedDocumentFields
    {
        public PartyInfo Supplier { get; set; }
        public PartyInfo Buyer { get; set; }
        public PartyInfo DeliveryParty { get; set; }
        public PartyInfo Shipper { get; set; }
        public PartyInfo Payer { get; set; }
        public PartyInfo Invoicee { get; set; }
        public PartyInfo UltimateCustomer { get; set; }
        public PartyInfo WarehouseKeeper { get; set; }

        public string OrdersNumber { get; set; }

        public DateTime? OrdersDate { get; set; }

        public string BlanketOrdersNumber { get; set; }

        public string FakeOrdersNumber { get; set; }

        public string ContractNumber { get; set; }

        public DateTime? ContractDate { get; set; }

        public string WaybillNumber { get; set; }
        public DateTime? WaybillDate { get; set; }

        public string EgaisFixationNumber { get; set; }
        public DateTime? EgaisFixationDate { get; set; }

        public string EgaisRegistrationNumber { get; set; }
    }
}