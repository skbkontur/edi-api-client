namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2
{
    /// <summary>Информация о титуле ЭЗЗ</summary>
    public class DiadocLogisticsOrderRequestInfo
    {
        /// <summary>Содержание операции</summary>
        public string OperationContent { get; set; }

        /// <summary>Список причин отказа в приёме заказа-заявки</summary>
        public string[] RejectionReasons { get; set; }
    }
}