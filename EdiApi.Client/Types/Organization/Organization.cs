using System;

namespace SkbKontur.EdiApi.Client.Types.Organization
{
    /// <summary>Информация об организации или точке доставки/отгрузки</summary>
    public class Organization
    {
        /// <summary>Дата начала работы</summary>
        public DateTime? OrganizationDate { get; set; }
        /// <summary>Информация об организации или точке доставки/отгрузки</summary>
        public PartyInfo OrganizationInfo { get; set; }
    }
}