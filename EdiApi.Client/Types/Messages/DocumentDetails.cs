using System;

namespace SkbKontur.EdiApi.Client.Types.Messages
{
    /// <summary>Информация о документе</summary>
    public class DocumentDetails
    {
        /// <summary>Тип документа</summary>
        public DocumentType DocumentType { get; set; }

        /// <summary>Флаг, показывающий, что данный документ является тестовым</summary>
        public bool DocumentIsTest { get; set; }

        /// <summary>Номер документа</summary>
        public string DocumentNumber { get; set; }

        /// <summary>Дата документа</summary>
        public DateTime? DocumentDate { get; set; }

        /// <summary>GLN точки доставки, указанный в документе</summary>
        public string DeliveryPointGln { get; set; }
    }
}