namespace SkbKontur.EdiApi.Client.Types.Common
{
    /// <summary>Содержимое вложения</summary>
    public class MessageAttachment
    {
        /// <summary>Имя вложенного файла</summary>
        public string AttachmentFileName { get; set; }

        /// <summary>Тело вложенного файла</summary>
        public byte[] AttachmentBody { get; set; }
    }
}