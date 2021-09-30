namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    public abstract class DiadocEventContentBase
    {
        /// <summary>Идентификатор ящика в Диадоке</summary>
        public string DiadocBoxId { get; set; }
        /// <summary>Идентификатор сообщения в Диадоке</summary>
        public string MessageId { get; set; }
        /// <summary>Идентификатор подписанного счёта-фактуры</summary>
        public string InvoiceId { get; set; }
        /// <summary>Идентификатор подписанной ТОРГ-12</summary>
        public string Torg12Id { get; set; }
        /// <summary>Идентификатор корректировочного счёта-фактуры</summary>
        public string InvoiceCorrectionId { get; set; }
        /// <summary>Идентификатор УПД</summary>
        public string UniversalTransferDocumentId { get; set; }
        /// <summary>Идентификатор УКД</summary>
        public string UniversalCorrectionDocumentId { get; set; }
        /// <summary>Идентификатор неформализованного документа</summary>
        public string NonformalizedId { get; set; }
        /// <summary>Ссылки на документы в Диадоке</summary>
        public DiadocUrls DiadocUrls { get; set; }
        /// <summary>Функция УПД</summary>
        public UniversalDocumentFunctionType? UniversalDocumentFunction { get; set; }
    }
}