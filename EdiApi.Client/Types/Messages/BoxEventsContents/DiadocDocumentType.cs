namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Тип документа в Диадоке</summary>
    public enum DiadocDocumentType
    {
        /// <summary>Счёт-фактура</summary>
        Invoice,
        /// <summary>Товарная накладная ТОРГ-12</summary>
        Torg12,
        /// <summary>Корректировочный счёт-фактура</summary>
        CorrectiveInvoice,
        /// <summary>УПД</summary>
        UniversalTransferDocument,
        /// <summary>УКД</summary>
        UniversalCorrectionDocument,
        /// <summary>Ценовой лист</summary>
        PriceList,
        /// <summary>Неформализованный документ</summary>
        Nonformalized
    }
}