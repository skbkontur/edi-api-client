using System;

using SkbKontur.EdiApi.Client.Types.Common;

namespace SkbKontur.EdiApi.Client.Types.Organization
{
    /// <summary>Реквизиты и адрес организации или точки доставки/отгрузки</summary>
    public class PartyInfo
    {
        /// <summary>GLN</summary>
        public string Gln { get; set; }

        /// <summary>Адрес</summary>
        public PartyAddress PartyAddress { get; set; }

        /// <summary>Георгафические координаты</summary>
        public GeoCoordinates GeoCoordinates { get; set; }

        /// <summary>Реквизиты российской организации</summary>
        public RussianPartyInfo RussianPartyInfo { get; set; }

        /// <summary>Реквизиты иностранной организации</summary>
        public ForeignPartyInfo ForeignPartyInfo { get; set; }

        /// <summary>Банковские реквизиты</summary>
        public BankAccount BankAccount { get; set; }

        /// <summary>Дополнительный идентификатор</summary>
        public string SupplierCodeInBuyerSystem { get; set; }

        /// <summary>Идентификатор хозяйствующего субъекта в ФГИС Меркурий</summary>
        public string BusinessEntityMercuryId { get; set; }

        /// <summary>Идентификатор торговой площадки ФГИС Меркурий</summary>
        public string AreaEntityMercuryId { get; set; }

        /// <summary>GLN филиала точки доставки</summary>
        public string FilialGln { get; set; }

        /// <summary>Данные о руководителе</summary>
        public ContactInformation Chief { get; set; }

        /// <summary>Данные о бухгалтере</summary>
        public ContactInformation Bookkeeper { get; set; }

        /// <summary>Данные о менеджере</summary>
        public ContactInformation SalesAdministration { get; set; }

        /// <summary>Данные о контактном лице</summary>
        public ContactInformation OrderContact { get; set; }

        /// <summary>Тип организации</summary>
        public string LocalizationType { get; set; }

        /// <summary>Применяется ли УСН</summary>
        public bool UsesSimplifiedTaxSystem { get; set; }

        /// <summary>Статус GLN</summary>
        public GlnStatus? GlnStatus { get; set; }

        /// <summary>Дата окончания оплаченного срока действия GLN</summary>
        public DateTime? GlnExpirationDate { get; set; }

        /// <summary>Дополнительный идентификатор точки доставки</summary>
        public string DeliveryPartyAdditionalCode { get; set; }
    }
}