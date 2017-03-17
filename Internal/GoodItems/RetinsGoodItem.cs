using System;

namespace KonturEdi.Api.Types.Internal.GoodItems
{
    public class RetinsGoodItem : CommonGoodItem
    {
        public string BuyerGroupProductCode { get; set; }

        public Quantity ReturnQuantity { get; set; }
        public Quantity RetinsQuantity { get; set; }

        public string OrdersNumber { get; set; }
        public DateTime? OrdersDate { get; set; }

        public string DespatchAdviceNumber { get; set; }
        public DateTime? DespatchDate { get; set; }

        public string DeliveryNoteNumber { get; set; }
        public DateTime? DeliveryNoteDate { get; set; }

        public PhysicalOrLogicalState[] ReturnPhysicalOrLogicalStates { get; set; }
    }
}