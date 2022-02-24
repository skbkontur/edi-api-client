namespace SkbKontur.EdiApi.Client.Types.Messages
{
    /// <summary>Данные организации, зарегистрированной в системе (используется для передачи информации о контрагентах)</summary>
    public class Partner
    {
        /// <summary>Уникальный идентификатор организации в системе</summary>
        public string PartnerId { get; set; }

        /// <summary>GLN</summary>
        public string PartnerGln { get; set; }

        /// <summary>Наименование</summary>
        public string PartnerName { get; set; }
    }
}