using System;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Время, затраченное на различные этапы обработки сообщения, и общее время доставки сообщения</summary>
    public class ProcessingTimes
    {
        /// <summary>Общее время доставки сообщения: разница между DocumentCirculationCompletionTimestamp и DocumentCirculationStartTimestamp</summary>
        public TimeSpan TotalWorkTime { get; set; }
        /// <summary>Время доставки за вычетом времени ожидания пользовательских действий или пользовательских интеграционных решений</summary>
        public TimeSpan? DeliveryTime { get; set; }
        /// <summary>Время обработки сообщения коннектором</summary>
        public TimeSpan? ConnectorWorkTime { get; set; }
        /// <summary>Время ожидания выполнения условий, необходимых для продолжения обработки коннектором</summary>
        public TimeSpan? ConnectorWaitTime { get; set; }
        /// <summary>Время между формированием черновиков документов в Диадоке и их подписанием</summary>
        public TimeSpan? DiadocWaitTime { get; set; }
        /// <summary>Время ожидания уведомления о приемке, при использовании соответствующей схемы взаимодействия между партнерами</summary>
        public TimeSpan? RecadvWaitTime { get; set; }
        /// <summary>Время с момента первой попытки доставки сообщения получателю до момента получения подтверждения доставки</summary>
        public TimeSpan? DeliveryNotificationWaitTime { get; set; }
    }
}