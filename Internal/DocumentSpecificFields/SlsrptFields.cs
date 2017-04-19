using System;

using KonturEdi.Api.Types.Internal.GoodItems;

namespace KonturEdi.Api.Types.Internal.DocumentSpecificFields
{
    public class SlsrptFields
    {
        public string FromGln { get; set; }
        public string ToGln { get; set; }

        public DateTime? SalesPeriodFrom { get; set; }
        public DateTime? SalesPeriodTo { get; set; }

        public string ContractNumber { get; set; }
        public DateTime? ContractDate { get; set; }

        public string SupplierGln { get; set; }
        public string BuyerGln { get; set; }

        public string CurrencyCode { get; set; }

        public SalesInLocation[] SalesInLocations { get; set; }
    }
}