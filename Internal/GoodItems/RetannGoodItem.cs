using System;

namespace KonturEdi.Api.Types.Internal.GoodItems
{
    public class RetannGoodItem : CommonGoodItem
    {
        public string BuyerGroupProductCode { get; set; }

        public Quantity ReturnQuantity { get; set; }

        public string ContractNumber { get; set; }
        public DateTime? ContractDate { get; set; }

        public string OrdersNumber { get; set; }
        public DateTime? OrdersDate { get; set; }

        public string DespatchAdviceNumber { get; set; }
        public DateTime? DespatchDate { get; set; }

        public string ReceivingAdviceNumber { get; set; }
        public DateTime? ReceivingDate { get; set; }

        public string InvoicNumber { get; set; }
        public DateTime? InvoicDate { get; set; }
    }
}