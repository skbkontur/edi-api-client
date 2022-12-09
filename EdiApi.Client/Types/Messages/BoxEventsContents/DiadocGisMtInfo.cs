namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Информация о статусе проверки в ГИС МТ "Честный ЗНАК"</summary>
    public class DiadocGisMtInfo
    {
        /// <summary>Идентификатор квитанции, полученной при взаимодействии с ГИС МТ "Честный ЗНАК"</summary>
        public string GisMtAttachmentEntityId { get; set; }

        /// <summary>Cтатус проверки в ГИС МТ "Честный ЗНАК"</summary>
        public DiadocGisMtStatus StatusNamedId { get; set; }
    }
}