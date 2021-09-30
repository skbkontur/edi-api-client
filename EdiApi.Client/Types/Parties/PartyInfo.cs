using System;

namespace SkbKontur.EdiApi.Client.Types.Parties
{
    /// <summary>Реквизиты организации</summary>
    public class PartyInfo
    {
        /// <summary>Идентификатор организации</summary>
        public string Id { get; set; }
        /// <summary>GLN организации</summary>
        public string Gln { get; set; }
        /// <summary>Наименование</summary>
        public string Name { get; set; }
        /// <summary>ИНН</summary>
        public string Inn { get; set; }
        /// <summary>КПП</summary>
        public string Kpp { get; set; }
        /// <summary>Тип организации</summary>
        public PartyType PartyTypeCode { get; set; }
        /// <summary>Идентификатор в Диадок</summary>
        public string DiadocOrgId { get; set; }
        /// <summary>Время последнего изменения реквизитов организации или ее структуры</summary>
        public DateTime? OrganizationCatalogueUpdateTime { get; set; }
        /// <summary>Организация приняла публичную оферту</summary>
        public bool LicenseAgreementAccepted { get; set; }
        /// <summary>Стратегия маршрутизации сообщений торговой сети</summary>
        public BuyerBoxSelectionStrategy BuyerBoxSelectionStrategy { get; set; }
        /// <summary>Стратегия маршрутизации сообщений поставщика</summary>
        public SupplierBoxSelectionStrategy SupplierBoxSelectionStrategy { get; set; }

        /// <summary>
        ///    Список платных услуг. В API эта информация доступна только сотрудникам организации, для остальных список будет пустой
        /// </summary>
        public PaidFeatureInfo[] PaidFeatures { get; set; }
    }
}