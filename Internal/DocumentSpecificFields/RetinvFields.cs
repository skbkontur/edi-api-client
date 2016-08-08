using System;

namespace KonturEdi.Api.Types.Internal.DocumentSpecificFields
{
    public class RetinvFields : InvoicFields
    {
        public string AnnouncementForReturnsNumber { get; set; }
        public DateTime? AnnouncementForReturnsDate { get; set; }

        public string InstructionsForReturnsNumber { get; set; }
        public DateTime? InstructionsForReturnsDate { get; set; }

        public string ReturnDeliveryNoteNumber { get; set; }
        public DateTime? ReturnDeliveryNoteDate { get; set; }

        public string ReturnDespatchNumber { get; set; }
        public DateTime? ReturnDespatchDate { get; set; }

        public string ReturnReceivingNumber { get; set; }
        public DateTime? ReturnReceivingDate { get; set; }
    }
}