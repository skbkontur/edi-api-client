using System;

namespace SkbKontur.EdiApi.Client.Types.Parties
{
    /// <summary>Информация об оплаченном периоде</summary>
    public class PaidPeriod
    {
        /// <summary>Дата начала периода</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>Дата окончания периода</summary>
        public DateTime? EndDate { get; set; }
    }
}