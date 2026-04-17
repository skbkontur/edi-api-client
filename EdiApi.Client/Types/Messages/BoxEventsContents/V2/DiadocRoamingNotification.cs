namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2
{
    /// <summary>Информация об отправке титула в роуминг</summary>
    public class DiadocRoamingNotification
    {
        /// <summary>Признак успешной отправки титула в роуминг</summary>
        public bool IsSuccess { get; set; }

        /// <summary>Описание результата отправки титула в роуминг</summary>
        public string Description { get; set; }
    }
}