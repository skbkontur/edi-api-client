namespace SkbKontur.EdiApi.Client.Types.Common
{
    /// <summary>Содержимое сообщения</summary>
    public class MessageData
    {
        /// <summary>Имя файла сообщения (используется при передаче сообщения специальными транспортами, например, FTP)</summary>
        public string MessageFileName { get; set; }

        /// <summary>Тело сообщения</summary>
        public byte[] MessageBody { get; set; }

        /// <summary>Список вложенных файлов</summary>
        public MessageAttachment[] MessageAttachments { get; set; }
    }
}