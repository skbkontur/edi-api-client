namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2
{
    /// <summary>Роль участника в контексте документа</summary>
    public enum DiadocDocumentParticipantRole
    {
        /// <summary>Неизвестно</summary>
        Unknown = 0,

        /// <summary>Грузоотправитель</summary>
        Consignor = 1,

        /// <summary>Перевозчик</summary>
        Carrier = 2,

        /// <summary>Грузополучатель</summary>
        Consignee = 3,
    }
}