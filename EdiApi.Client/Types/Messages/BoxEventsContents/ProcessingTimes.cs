using System;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    public class ProcessingTimes
    {
        public TimeSpan TotalWorkTime { get; set; }
        public TimeSpan? DeliveryTime { get; set; }
        public TimeSpan? ConnectorWorkTime { get; set; }
        public TimeSpan? ConnectorWaitTime { get; set; }
        public TimeSpan? DiadocWaitTime { get; set; }
        public TimeSpan? RecadvWaitTime { get; set; }
        public TimeSpan? DeliveryNotificationWaitTime { get; set; }
    }
}