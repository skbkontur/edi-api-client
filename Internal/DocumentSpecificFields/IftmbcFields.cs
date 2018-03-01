using System;

namespace KonturEdi.Api.Types.Internal.DocumentSpecificFields
{
    public class IftmbcFields
    {
        public string VersionOf1C { get; set; }
        public string VersionOfModule1C { get; set; }
        public DateTime? CreationDateTimeBySender { get; set; }
        public string BookingConfirmationNumber { get; set; }
        public DateTime? BookingConfirmationDate { get; set; }
        public string FirmBookingNumber { get; set; }
        public DateTime? FirmBookingDate { get; set; }
        public BookingConfirmationStatus? BookingConfirmationStatus { get; set; }
        public DateTime? EstimatedExportDate { get; set; }
        public string SupplierGln { get; set; }
        public string BuyerGln { get; set; }
        public string CarrierGln { get; set; }
        public string DespatchPartyGln { get; set; }
        public IftmbcTransportDetails TransportDetails { get; set; }
        public decimal? TotalPackagesQuantity { get; set; }
    }
}