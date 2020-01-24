using System;

using SkbKontur.EdiApi.Types.Internal.GoodItems;

namespace SkbKontur.EdiApi.Types.Internal.DocumentSpecificFields
{
    public class DelforFields
    {
        public string FromGln { get; set; }
        public string ToGln { get; set; }
        public DelforType? DelforType { get; set; }
        public DelforFunctionCode? DelforFunctionCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ContractNumber { get; set; }
        public DateTime? ContractDate { get; set; }
        public string SalesRegion { get; set; }
        public string Comment { get; set; }
        public string SegmentOfBuyerAssortment { get; set; }
        public DeliveryForecastDuration? Duration { get; set; }
        public string SupplierGln { get; set; }
        public string BuyerGln { get; set; }
        public string VersionOf1C { get; set; }
        public string VersionOfModule1C { get; set; }
        public ScheduleItem[] ScheduleItems { get; set; }
    }

    public class ScheduleItem
    {
        public string DeliveryPartyGln { get; set; }
        public DeliveryForecastInfo[] DeliveryForecastInfos { get; set; }
    }

    public class DeliveryForecastInfo
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public DeliveryForecastStatus? Status { get; set; }

        public string OrdersForecastNumber { get; set; }
        public string OrdersForecastName { get; set; }

        public Quantity MinimumNetWeight { get; set; }
        public Quantity MinimumNumberOfPalletPlaces { get; set; }
        public decimal? MinimumNetAmount { get; set; }
        public string Comment { get; set; }
        public DeliveryForecastDuration? Duration { get; set; }
        public FrequencyOfDelivery FrequencyOfDelivery { get; set; }
        public DateTime? PlannedOrderDate { get; set; }
        public DateTime? PlannedDeliveryDate { get; set; }
        public TimeSpan? SendOrderToTime { get; set; }
        public int? DaysForDelivery { get; set; }
        public TimeSpan? VehicleArrivalFromTime { get; set; }
        public TimeSpan? VehicleArrivalToTime { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DeletionDate { get; set; }
    }

    public class FrequencyOfDelivery
    {
        public WeekRegularities? Weeks { get; set; }
        public WeekDays[] Days { get; set; }
    }

    public enum DelforType
    {
        Inquiry,
        Schedule,
        Response,
        Forecast,
    }

    public enum DelforFunctionCode
    {
        Original,
        Accepted,
        NotAccepted,
        AcceptedWithAmendment,
    }

    public enum DeliveryForecastDuration
    {
        Temporary,
        Regular,
    }

    public enum DeliveryForecastStatus
    {
        Added,
        Deleted,
        Changed,
        Accepted,
        NotAccepted,
    }

    public enum WeekRegularities
    {
        EvenWeeks,
        OddWeeks,
        EveryWeek,
    }

    public enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }
}