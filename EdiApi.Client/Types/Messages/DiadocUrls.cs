namespace SkbKontur.EdiApi.Client.Types.Messages
{
    /// <summary>Ссылки на документы в Диадоке</summary>
    public class DiadocUrls
    {
        /// <summary>Ссылка на сообщение в Диадоке</summary>
        public string MessageUrl { get; set; }
        /// <summary>Ссылка на счёт-фактуру в Диадоке</summary>
        public string InvoiceUrl { get; set; }
        /// <summary>Ссылка на ТОРГ-12 в Диадоке</summary>
        public string Torg12Url { get; set; }
        /// <summary>Ссылка на корректировочный счёт-фактуру в Диадоке</summary>
        public string InvoiceCorrectionUrl { get; set; }
        /// <summary>Ссылка на УПД в Диадоке</summary>
        public string UniversalTransferDocumentUrl { get; set; }
        /// <summary>Ссылка на УКД в Диадоке</summary>
        public string UniversalCorrectionDocumentUrl { get; set; }
        /// <summary>Ссылка на ценовой лист в Диадоке</summary>
        public string PriceListUrl { get; set; }
        /// <summary>Ссылка на неформализованный документ в Диадоке</summary>
        public string NonformalizedUrl { get; set; }
    }
}