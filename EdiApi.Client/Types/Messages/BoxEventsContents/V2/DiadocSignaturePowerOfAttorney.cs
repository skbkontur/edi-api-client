namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2
{
    /// <summary>Информация об МЧД и её статусе проверки</summary>
    public class DiadocSignaturePowerOfAttorney
    {
        /// <summary>Идентификатор сущности МЧД</summary>
        public string EntityId { get; set; }

        /// <summary>Полный идентификатор МЧД</summary>
        public DiadocPowerOfAttorneyFullId FullId { get; set; }

        /// <summary>Информация о статусе проверки МЧД</summary>
        public DiadocPowerOfAttorneyValidationStatusV2 Status { get; set; }
    }
}