using System;

namespace SkbKontur.EdiApi.Client.Types.Parties
{
    public class PaidFeatureInfo
    {
        public Guid BillingAccountId { get; set; }
        public PaidFeatureType PaidFeatureType { get; set; }
        public PaidPeriod[] PaidPeriods { get; set; }
        public DateTime? GracePeriodEnd { get; set; }
    }

    public enum PaidFeatureType
    {
        Unknown = 0,
        Module1C = 1,
        FtpTransport = 2
    }

    public class PaidPeriod
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}