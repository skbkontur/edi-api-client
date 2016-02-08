using System;

namespace KonturEdi.Api.Types.Messages
{
    public class MessageDeliveryResult
    {
        public DateTime? DeliveryTimestamp { get; set; }

        //[CanBeNull]
        public string DeliveryError { get; set; }

        public DateTime FirstDeliveryAttemptTimestamp { get; set; }
    }
}