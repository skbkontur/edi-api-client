using System;

namespace SkbKontur.EdiApi.Types.Internal.DocumentSpecificFields
{
    public abstract class OrderBasedDocumentFields
    {
        public string SupplierGln { get; set; }
        public string BuyerGln { get; set; }
        public string DeliveryPartyGln { get; set; }
        public string ShipperGln { get; set; }
        public string PayerGln { get; set; }
        public string InvoiceeGln { get; set; }
        public string UltimateCustomerGln { get; set; }
        public string WarehouseKeeperGln { get; set; }

        public string VersionOfModule1C { get; set; }
        public string VersionOf1C { get; set; }

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