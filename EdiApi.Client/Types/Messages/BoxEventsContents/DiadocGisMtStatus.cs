namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Cтатус проверки в ГИС МТ "Честный ЗНАК"</summary>
    public class DiadocGisMtStatus
    {
        /// <summary>Статус проверки в ГИС МТ "Честный ЗНАК"</summary>
        public DiadocGisMtStatusNamedId StatusNamedId { get; set; }

        /// <summary>Тип статуса обработки в ГИС МТ "Честный ЗНАК"</summary>
        public DiadocGisMtOuterStatusType StatusType { get; set; }

        /// <summary>Описание статуса в ГИС МТ "Честный ЗНАК"</summary>
        public string Description { get; set; } = default!;

        /// <summary>Список ошибок, которые были получены при взаимодействии с ГИС МТ "Честный ЗНАК" в рамках документооборота</summary>
        public DiadocGisMtStatusDetail[] Details { get; set; }
    }
}