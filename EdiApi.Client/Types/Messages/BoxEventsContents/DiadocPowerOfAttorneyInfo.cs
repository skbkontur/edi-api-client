namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Информация об МЧД и её текущем статусе проверки</summary>
    public class DiadocPowerOfAttorneyInfo
    {
        /// <summary>Идентификатор подписанного с МЧД документа в пакете документов</summary>
        public string DocumentEntityId { get; set; }
        
        /// <summary>Идентификатор МЧД в пакете документов</summary>
        public string PowerOfAttorneyEntityId { get; set; }
        
        /// <summary>Идентификатор изменения статуса в истории изменений статусов проверки МЧД</summary>
        public string PowerOfAttorneyStatusChangeEntityId { get; set; }
        
        /// <summary>Полный идентификатор МЧД</summary>
        public DiadocPowerOfAttorneyFullId PowerOfAttorneyFullId { get; set; }
        
        /// <summary>Текущий статус проверки МЧД</summary>
        public DiadocPowerOfAttorneyValidationStatus PowerOfAttorneyValidationStatus { get; set; }
    }
}