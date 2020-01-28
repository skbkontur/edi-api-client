using System;

using SkbKontur.EdiApi.Types.Internal.GoodItems;

namespace SkbKontur.EdiApi.Types.Internal.DocumentSpecificFields
{
    public class OrdrspFields : OrderBasedDocumentFields
    {
        public OrdrspDocumentStatus? StatusResponse { get; set; }

        public DateTime? OrderedDeliveryDate { get; set; }

        public DateTime? EstimatedDeliveryDate { get; set; }

        public DateTime? ExportDateTimeFromSupplier { get; set; }

        public string CurrencyCode { get; set; }

        public decimal? OrdrspTotal { get { return ordrspTotal ?? ordrspTaxableTotal; } set { ordrspTotal = value; } }

        public decimal? OrdrspTaxableTotal { get { return ordrspTaxableTotal ?? ordrspTotal; } set { ordrspTaxableTotal = value; } }

        public decimal? OrdrspTotalWithVAT { get; set; }

        public decimal? OrdrspTotalVAT { get; set; }

        public string TransportBy { get; set; }

        public string RevisionNumber { get; set; }

        public OrdrspTransportDetails[] TransportDetails { get; set; }
        public CommonGoodItem[] GoodItems { get; set; }

        private decimal? ordrspTotal;
        private decimal? ordrspTaxableTotal;
    }

    public class OrdrspTransportDetails
    {
        public string TransportMode { get; set; }
        public string VehicleNumber { get; set; }
        public string VehicleBrand { get; set; }
        public string NameOfCarrier { get; set; }

        public DateTime? EstimatedDeliveryDateForVehicle { get; set; }
    }

    public enum OrdrspDocumentStatus
    {
        Accepted,
        Rejected,
        Changed
    }
}