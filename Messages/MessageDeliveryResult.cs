using System;

namespace KonturEdi.Api.Types.Messages
{
    public class MessageDeliveryResult
    {
        public DateTime FirstDeliveryToClientTime { get; set; } // for SLA
        public DateTime? SuccessfulDeliveryTime { get; set; }
        public string[] DeliveryErrors { get; set; }
    }
}