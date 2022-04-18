namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Ошибка проверки статуса МЧД</summary>
    public class DiadocPowerOfAttorneyValidationStatusError
    {
        /// <summary>Код ошибки</summary>
        public string Code { get; set; }

        /// <summary>Текст ошибки</summary>
        public string Text { get; set; }
    }
}