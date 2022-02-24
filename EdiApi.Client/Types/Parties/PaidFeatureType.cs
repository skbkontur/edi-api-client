namespace SkbKontur.EdiApi.Client.Types.Parties
{
    /// <summary>Тип платной услуги</summary>
    public enum PaidFeatureType
    {
        /// <summary>Неизвестно</summary>
        Unknown = 0,

        /// <summary>Модуль 1C API</summary>
        Module1C = 1,

        /// <summary>Транспорт FTP</summary>
        FtpTransport = 2,
    }
}