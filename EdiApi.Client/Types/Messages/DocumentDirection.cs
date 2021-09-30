namespace SkbKontur.EdiApi.Client.Types.Messages
{
    /// <summary>Направления отправки документов</summary>
    public enum DocumentDirection
    {
        /// <summary>Исходящий</summary>
        FromMe,
        /// <summary>Входящий</summary>
        ToMe,
        /// <summary>Сообщение может быть входящим или исходящим</summary>
        Bidirectional
    }
}