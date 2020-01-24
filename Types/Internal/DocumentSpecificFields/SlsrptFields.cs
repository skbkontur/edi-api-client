using System;

using SkbKontur.EdiApi.Types.Internal.GoodItems;

namespace SkbKontur.EdiApi.Types.Internal.DocumentSpecificFields
{
    public class SlsrptFields
    {
        public string FromGln { get; set; }
        public string ToGln { get; set; }

        public DateTime? SalesPeriodFrom { get; set; }
        public DateTime? SalesPeriodTo { get; set; }

        public DateTime? SubscriptionPeriodStartDate { get; set; }
        public DateTime? SubscriptionPeriodEndDate { get; set; }

        public string ContractNumber { get; set; }
        public DateTime? ContractDate { get; set; }

        public string SupplierGln { get; set; }
        public string BuyerGln { get; set; }

        public string CurrencyCode { get; set; }

        public string StoreFormats { get; set; }

        public string VersionOf1C { get; set; }
        public string VersionOfModule1C { get; set; }

        public SalesInLocation[] SalesInLocations { get; set; }
    }
}