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
}