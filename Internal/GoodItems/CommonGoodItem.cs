using System;

using KonturEdi.Api.Types.Organization;

namespace KonturEdi.Api.Types.Internal.GoodItems
{
    public class CommonGoodItem : GoodItemBase
    {
        public GoodNumber GoodNumber { get; set; }

        public string OrderLineNumber { get; set; }

        public string CodeOfEgais { get; set; }

        public DateTime? ExpireDate { get; set; }

        public DateTime? FreshnessDate { get; set; }

        public DateTime? ManufactoringDate { get; set; }

        public decimal? Price { get; set; }

        public decimal? PriceCataloguePrice { get; set; }

        public decimal? PriceWithVAT { get; set; }

        public decimal? PriceSummary { get; set; }

        public decimal? PriceSummaryWithVAT { get; set; }

        public string FlowType { get; set; }
        public decimal? PriceWithDiscount { get; set; }

        public CustomDeclaration[] CustomDeclarations { get; set; }

        public string[] CountriesOfOriginCode { get; set; }

        public string VATRate { get; set; }

        public decimal? ExciseTax { get; set; }

        public decimal? VATSummary { get; set; }

        public Quantity OnePlaceQuantity { get; set; }
        public Quantity PackageQuantity { get; set; }

        public Quantity OrdersQuantity { get; set; }
        public Quantity OrdrspQuantity { get; set; }
        public Quantity DesadvQuantity { get; set; }
        public Quantity RecadvQuantity { get; set; }
        public Quantity InvoicQuantity { get; set; }

        public Quantity DeliveredQuantity { get; set; }

        public int? PackageLevel { get; set; }

        public PartyInfo UltimateCustomer { get; set; }

        public GoodItemAdditionalInfo AdditionalInfo { get; set; }
    }

    public class CustomDeclaration
    {
        public string Number { get; set; }

        public DateTime? Date { get; set; }
    }
}