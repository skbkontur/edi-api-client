namespace SkbKontur.EdiApi.Client.Types.Messages
{
    /// <summary>Настройки товарных позиций</summary>
    public class GoodItemsSettings
    {
        /// <summary>GTIN не требуется в товарной позиции</summary>
        public bool GtinIsNotRequired { get; set; }
    }
}