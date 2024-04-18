namespace SkbKontur.EdiApi.Client.Types.Messages
{
    /// <summary>Настройки обмена документами с конкретным контрагентом</summary>
    public class DocumentsSettingsForPartner
    {
        /// <summary>Организация-контрагент</summary>
        public Partner Partner { get; set; }

        /// <summary>Набор документов, которыми можно обмениваться с контрагентом</summary>
        public DocumentSettings[] DocumentSettings { get; set; }

        /// <summary>Настройки товарных позиций</summary>
        public GoodItemsSettings GoodItemsSettings { get; set; }
    }
}