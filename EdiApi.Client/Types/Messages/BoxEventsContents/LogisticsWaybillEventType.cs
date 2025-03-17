#nullable enable

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Тип события по транспортной накладной в Контур.Логистике</summary>
    public enum LogisticsWaybillEventType
    {
        /// <summary>Неизвестно</summary>
        Unknown = 0,

        /// <summary>Транспортная накладная создана</summary>
        TransportationCreated = 1,

        /// <summary>Выполнено действие с черновиком</summary>
        DraftAction = 2,

        /// <summary>Подписан титул грузоотправителя Т1</summary>
        ConsignorTitleSigned = 3,

        /// <summary>Подписан титул перевозчика на погрузке Т2</summary>
        CarrierReceptionTitleSigned = 4,

        /// <summary>Подписан титул грузополучателя Т3</summary>
        ConsigneeTitleSigned = 5,

        /// <summary>Подписан титул перевозчика на выгрузке Т4</summary>
        CarrierDeliveryTitleSigned = 6,

        /// <summary>Подписан титул перевозчика о стоимости Т5</summary>
        CarrierPaymentTitleSigned = 7,

        /// <summary>Подписан титул грузоотправителя о стоимости Т6</summary>
        ConsignorPaymentTitleSigned = 8,

        /// <summary>Подписан титул переадресовки Т7</summary>
        ReaddressTitleSigned = 9,

        /// <summary>Подписан титул эстафеты Т8</summary>
        RelayTitleSigned = 10,

        /// <summary>Подписан титул отклонения</summary>
        RejectTitleSigned = 11,

        /// <summary>Титул переслан третьему участнику транспортной накладной и наблюдателям</summary>
        TitleForwarded = 12,

        /// <summary>Титул согласован с водителем</summary>
        TitleApprovedByDriver = 13,

        /// <summary>Транспортная накладная перемещена в архив</summary>
        TransportationArchived = 14,

        /// <summary>Транспортная накладная восстановлена из архива</summary>
        TransportationUnarchived = 15,
    }
}