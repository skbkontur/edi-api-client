namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2
{
    /// <summary>Статус титула документа, относящийся к участнику документооборота</summary>
    public enum DiadocParticipantTitleStatus
    {
        /// <summary>Неизвестно</summary>
        Unknown = 0,

        /// <summary>Подпись титула отклонена</summary>
        SigningRejected = 1,

        /// <summary>Титул подписан</summary>
        Signed = 2,
    }
}