namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2
{
    /// <summary>Информация об отклонении подписи</summary>
    public class DiadocSignatureRejection
    {
        /// <summary>Список причин отклонения подписи</summary>
        public string[] Reasons { get; set; }
    }
}