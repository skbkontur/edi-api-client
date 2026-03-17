#nullable enable

namespace SkbKontur.EdiApi.Client.Types.Parties
{
    public class PartySettings
    {
        public PartySettings() =>
            ReportingSettings = new ReportingSettings();

        public IntegrationType IntegrationType { get; set; }

        public ReportingSettings ReportingSettings { get; set; }
    }

    public enum IntegrationType
    {
        Undefined = 0,
        Module1C = 1,
        SelfDevelopedSolution = 2,
        Web = 3,
        BuyerModule1C = 4,
        SmallRetail = 5,
        Market = 6,
        BuyerSelfDevelopedSolution = 7,
    }

    public class ReportingSettings
    {
        public ReportingSettings() =>
            ChestnyZnakReportingProductCategories = new ChestnyZnakReportingProductCategories();

        public bool Egais { get; set; }
        public bool Mercury { get; set; }

        public ChestnyZnakReportingProductCategories ChestnyZnakReportingProductCategories { get; set; }
    }

    public class ChestnyZnakReportingProductCategories
    {
        public bool Tobacco { get; set; }
    }
}