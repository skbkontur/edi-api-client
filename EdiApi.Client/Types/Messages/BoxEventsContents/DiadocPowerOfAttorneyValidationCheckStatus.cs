namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Результат выполнения проверки МЧД</summary>
    public enum DiadocPowerOfAttorneyValidationCheckStatus
    {
        /// <summary>Значение по умолчанию</summary>
        UnknownCheckStatus = 0,

        /// <summary>Проверка успешно пройдена</summary>
        Ok = 1,

        /// <summary>Есть предупреждение</summary>
        Warning = 2,

        /// <summary>Есть ошибка</summary>
        Error = 3,
    }
}