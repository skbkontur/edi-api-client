namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Идентификатор статуса проверки МЧД</summary>
    public enum DiadocPowerOfAttorneyValidationStatusNamedId
    {
        /// <summary>Неизвестный статус</summary>
        UnknownStatus = 0,

        /// <summary>МЧД не может быть проверена</summary>
        CanNotBeValidated = 1,

        /// <summary>МЧД валидна</summary>
        IsValid = 2,

        /// <summary>МЧД не валидна</summary>
        IsNotValid = 3,

        /// <summary>Ошибка во время проверки МЧД</summary>
        ValidationError = 4,

        /// <summary>МЧД не приложена к подписи, возвращается только для общего (сводного) статуса МЧД</summary>
        IsNotAttached = 5,

        /// <summary>Часть проверок не может быть выполнена или была выполнена с предупреждениями</summary>
        HasWarnings = 6,
    }
}