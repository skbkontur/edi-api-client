using System;

using KonturEdi.Api.Types.Internal.GoodItems;
using KonturEdi.Api.Types.Organization;

namespace KonturEdi.Api.Types.Internal.DocumentSpecificFields
{
    public class PricatFields
    {
        public string FromGln { get; set; }

        public string ToGln { get; set; }

        public PriceCatalogueType? PriceCatalogueType { get; set; }
        public PriceCatalogueFunctionCode? PriceCatalogueFunctionCode { get; set; }

        public string OriginPriceCatalogueNumber { get; set; }
        public DateTime? OriginPriceCatalogueDate { get; set; }

        public IdentifierInPriceChain IdentifierInPriceChain { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public string ContractNumber { get; set; }
        public DateTime? ContractDate { get; set; }

        public DateTime? AdviseBeforeDate { get; set; }

        public string SegmentOfBuyerAssortment { get; set; }

        public string[] FinancialCodes { get; set; }

        public PartyInfo Supplier { get; set; }
        public PartyInfo Buyer { get; set; }

        public PartyInfo[] DeliveryParties { get; set; }

        public string CurrencyCode { get; set; }

        public string SalesRegion { get; set; }

        public string Comment { get; set; }

        public string PrivateNote { get; set; }

        public PriceListGoodItem[] GoodItems { get; set; }
    }

    public enum PriceCatalogueType
    {
        Undefined,
        Response,
        Request,
        Update,
        MarketingPrice,
        Catalogue,
        Inquiry
    }

    public enum PriceCatalogueFunctionCode
    {
        Undefined,
        Change,
        Original,
        NotAccepted,
        Provisional,
        Definitive
    }

    public class IdentifierInPriceChain
    {
        public string Number { get; set; }
        public DateTime? Date { get; set; }
        public string PreviousNumber { get; set; }
        public DateTime? PreviousDate { get; set; }
    }
}