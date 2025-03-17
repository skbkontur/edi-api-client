using SkbKontur.EdiApi.Client.Types.BoxEvents;

#nullable enable

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии OutboxLogisticsWaybillTitlePostingStatusEventContent в ящике отправителя</summary>
    public class OutboxLogisticsWaybillTitlePostingStatusEventContent : IBoxEventContent
    {
        /// <summary>Информация о статусе отправки титула транспортной накладной в Контур.Логистику</summary>
        public LogisticsWaybillTitlePostingStatusInfo WaybillTitlePostingStatusInfo { get; set; } = null!;
    }
}