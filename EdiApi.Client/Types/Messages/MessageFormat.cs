namespace SkbKontur.EdiApi.Client.Types.Messages
{
    /// <summary>Формат сообщения</summary>
    public enum MessageFormat
    {
        /// <summary>Не удалось определить формат собщения</summary>
        Unknown,

        /// <summary>Не задан отдельный формат сообщения. Значение может быть возвращено в структуре BoxSettings при вызове метода GetBoxesInfo</summary>
        Any,

        /// <summary>iCat.EDI XML</summary>
        KonturXml,

        /// <summary>Корус-xml</summary>
        KorusXml,

        /// <summary>EANCOM 2002</summary>
        Eancom2002,

        /// <summary>ECR-Rus XML</summary>
        EcrRusXml,
    }
}