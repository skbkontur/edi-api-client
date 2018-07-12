using System;

using KonturEdi.Api.Types.Internal.GoodItems;

namespace KonturEdi.Api.Types.Internal.DocumentSpecificFields
{
    public class InvrptFields
    {
        public string FromGln { get; set; }
        public string ToGln { get; set; }

        public DateTime? InventoryDate { get; set; }
        public DateTime? InventoryPeriodFrom { get; set; }
        public DateTime? InventoryPeriodTo { get; set; }

        public string ContractNumber { get; set; }
        public DateTime? ContractDate { get; set; }

        public string SupplierGln { get; set; }
        public string BuyerGln { get; set; }
        public string InventoryReporterGln { get; set; }

        public string CurrencyCode { get; set; }
        public string VersionOf1C { get; set; }
        public string VersionOfModule1C { get; set; }
        public InvrptGoodItem[] GoodItems { get; set; }
    }
}