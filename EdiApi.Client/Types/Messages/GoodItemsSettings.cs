namespace SkbKontur.EdiApi.Client.Types.Messages
{
    /// <summary>Настройки товарных позиций</summary>
    public class GoodItemsSettings
    {
        /// <summary>GTIN требуется в товарной позиции</summary>
        public bool GtinIsRequired { get; set; }
    }
}