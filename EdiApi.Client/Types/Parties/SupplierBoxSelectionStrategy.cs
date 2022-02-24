namespace SkbKontur.EdiApi.Client.Types.Parties
{
    /// <summary>Стратегии маршрутизации сообщений поставщика</summary>
    public enum SupplierBoxSelectionStrategy
    {
        /// <summary>Использовать для маршрутизации головной GLN организации</summary>
        Default,

        /// <summary>Использовать для маршрутизации GLN поставщика, указанный в сообщении</summary>
        Supplier,

        /// <summary>Использовать для маршрутизации GLN грузоотправителя, указанный в сообщении</summary>
        Shipper,
    }
}