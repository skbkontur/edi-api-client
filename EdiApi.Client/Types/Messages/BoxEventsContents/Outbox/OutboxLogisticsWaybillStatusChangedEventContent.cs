#nullable enable

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии OutboxLogisticsWaybillStatusChangedEventContent в ящике отправителя</summary>
    public class OutboxLogisticsWaybillStatusChangedEventContent : OutboxEventContentBase
    {
        /// <summary>Информация о статусе транспортной накладной в Контур.Логистике</summary>
        public LogisticsWaybillStatusInfo WaybillStatusInfo { get; set; } = null!;
    }
}