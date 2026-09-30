namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Группа кодов универсального сообщения в Диадоке</summary>
    public enum DiadocUniversalMessageCodeGroup
    {
        /// <summary>Неизвестная группа кодов</summary>
        Unknown = 0,

        /// <summary>Извещение о получении</summary>
        Receipt = 1,

        /// <summary>Уведомление об уточнении</summary>
        AmendmentRequest = 2,

        /// <summary>Отказ</summary>
        Rejection = 3,

        /// <summary>Информационное сообщение</summary>
        InformationMessage = 4,
    }
}