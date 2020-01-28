using SkbKontur.EdiApi.Client.Types.Internal.GoodItems;

namespace SkbKontur.EdiApi.Client.Types.Internal.DocumentSpecificFields
{
    public class IftmbcTransportDetails
    {
        public string TransportMode { get; set; }
        public bool? HasTailLift { get; set; }
        public Quantity TruckCapacity { get; set; }
        public Quantity PalletPlacesQuantity { get; set; }
        public string TypeOfTransportCode { get; set; }
        public string VoyageNumber { get; set; }
        public string VehicleNumber { get; set; }
        public string VehicleBrand { get; set; }
        public string NameOfCarrier { get; set; }
        public string PhoneOfCarrier { get; set; }
        public string DriverLicenseNumber { get; set; }
        public string CarriersPassportSeries { get; set; }
        public string CarriersPassportNumber { get; set; }
        public string Comment { get; set; }
    }
}