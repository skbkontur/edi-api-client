using System;

namespace SkbKontur.EdiApi.Client.Types.Parties
{
    /// <summary>Информация о платных услугах</summary>
    public class PaidFeatureInfo
    {
        /// <summary>Идентификатор лицевого счета в системе Контур.Биллинг</summary>
        public Guid BillingAccountId { get; set; }
        /// <summary>Тип платной услуги</summary>
        public PaidFeatureType PaidFeatureType { get; set; }
        /// <summary>Список оплаченных периодов</summary>
        public PaidPeriod[] PaidPeriods { get; set; }
        /// <summary>Дата окончания действия льготного периода</summary>
        public DateTime? GracePeriodEnd { get; set; }
    }
}