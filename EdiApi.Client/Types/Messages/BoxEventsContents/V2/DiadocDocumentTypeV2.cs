namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2
{
    /// <summary>Тип документа</summary>
    public enum DiadocDocumentTypeV2
    {
        /// <summary>Неизвестно</summary>
        Unknown = 0,

        /// <summary>Электронная транспортная накладная (ЭТрН)</summary>
        LogisticsWaybill = 1,

        /// <summary>Электронный заказ-заявка (ЭЗЗ)</summary>
        LogisticsOrderRequest = 2,
    }
}