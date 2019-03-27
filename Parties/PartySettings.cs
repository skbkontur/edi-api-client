using JetBrains.Annotations;

namespace KonturEdi.Api.Types.Parties
{
    public class PartySettings
    {
        public PartySettings()
        {
            ReportingSettings = new ReportingSettings();
        }

        public IntegrationType IntegrationType { get; set; }

        [NotNull]
        public ReportingSettings ReportingSettings { get; set; }
    }

    public enum IntegrationType
    {
        Undefined,
        Module1C,
        SelfDevelopedSolution,
        Web
    }

    public class ReportingSettings
    {
        public ReportingSettings()
        {
            ChestnyZnakReportingProductCategories = new ChestnyZnakReportingProductCategories();
        }

        public bool Egais { get; set; }
        public bool Mercury { get; set; }

        [NotNull]
        public ChestnyZnakReportingProductCategories ChestnyZnakReportingProductCategories { get; set; }
    }

    public class ChestnyZnakReportingProductCategories
    {
        public bool Tobacco { get; set; }
    }
}