using System;

using KonturEdi.Api.Types.Internal.GoodItems;

namespace KonturEdi.Api.Types.Internal.DocumentSpecificFields
{
    public class OrdersFields : OrderBasedDocumentFields
    {
        public string ProposalOrdersNumber { get; set; }
        public DateTime? ProposalOrdersDate { get; set; }

        public string FreeText { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public DateTime? ExportDateTimeFromSupplier { get; set; }

        public string FlowType { get; set; }

        public bool CanBePartiallyDelivered { get; set; }

        public string CurrencyCode { get; set; }

        public decimal? OrdersTotal { get { return ordersTotal ?? ordersTaxableTotal; } set { ordersTotal = value; } }

        public decimal? OrdersTotalWithVat { get; set; }

        public decimal? OrdersTaxableTotal { get { return ordersTaxableTotal ?? ordersTotal; } set { ordersTaxableTotal = value; } }

        public decimal? OrdersTotalVAT { get; set; }

        public decimal? OrdersTotalPackageQuantity { get; set; }

        public bool IsPromotionalPrice { get; set; }
        public string PromotionalDealNumber { get; set; }

        public string TransportBy { get; set; }

        public DocumentRevisionType DocumentRevisionType { get; set; }

        public string RevisionNumber { get; set; }

        public DateTime? DocumentSendDateTime { get; set; }

        public OrdersTransportDetails[] TransportDetails { get; set; }
        public CommonGoodItem[] GoodItems { get; set; }

        private decimal? ordersTotal;
        private decimal? ordersTaxableTotal;
    }

    public class OrdersTransportDetails
    {
        public DateTime? DeliveryDateForVehicle { get; set; }
    }
}