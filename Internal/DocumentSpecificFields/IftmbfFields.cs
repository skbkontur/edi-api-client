using System;

using KonturEdi.Api.Types.Internal.GoodItems;

namespace KonturEdi.Api.Types.Internal.DocumentSpecificFields
{
    public class IftmbfFields
    {
        public string VersionOf1C { get; set; }
        public string VersionOfModule1C { get; set; }
        public DateTime? CreationDateTimeBySender { get; set; }
        public string FirmBookingNumber { get; set; }
        public DateTime? FirmBookingDate { get; set; }
        public DocumentRevisionType DocumentRevisionType { get; set; }
        public DateTime? AttorneyLetterDate { get; set; }
        public DateTime? ExportDate { get; set; }
        public string OrdersNumber { get; set; }
        public DateTime? OrdersDate { get; set; }
        public string ForwardingOrderNumber { get; set; }
        public DateTime? ForwardingOrderDate { get; set; }
        public string ContractNumber { get; set; }
        public DateTime? ContractDate { get; set; }
        public string PackageStorageTemperature { get; set; }
        public string ProductsCategory { get; set; }
        public string SupplierGln { get; set; }
        public string BuyerGln { get; set; }
        public string CarrierGln { get; set; }
        public string DespatchPartyGln { get; set; }
        public string[] DeliveryPartiesGlns { get; set; }
        public IftmbfTransportDetails TransportDetails { get; set; }
        public Quantity TotalPackagesGrossWeight { get; set; }
        public decimal? TotalPackagesQuantity { get; set; }
    }
}