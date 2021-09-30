namespace SkbKontur.EdiApi.Client.Types.Organization
{
    /// <summary>Информация о структуре организации</summary>
    public class OrganizationCatalogueInfo
    {
        /// <summary>Связанные юридические лица и/или индивидуальные предприниматели</summary>
        public Organization[] Organizations { get; set; }
        /// <summary>Точки доставки/отгрузки</summary>
        public Organization[] DeliveryPoints { get; set; }
    }
}