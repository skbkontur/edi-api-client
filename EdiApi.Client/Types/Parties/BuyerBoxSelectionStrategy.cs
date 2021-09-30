namespace SkbKontur.EdiApi.Client.Types.Parties
{
    /// <summary>Стратегии маршрутизации сообщений торговой сети</summary>
    public enum BuyerBoxSelectionStrategy
    {
        /// <summary>Использовать для маршрутизации головной GLN организации</summary>
        Default,
        /// <summary>Использовать для маршрутизации GLN покупателя, указанный в сообщении</summary>
        Buyer,
        /// <summary>Использовать для маршрутизации GLN грузополучателя, указанный в сообщении</summary>
        DeliveryPoint,
        /// <summary>Использовать для маршрутизации GLN получателя счёта, указанный в сообщении</summary>
        Invoicee,
        /// <summary>Использовать для маршрутизации GLN плательщика, указанный в сообщении</summary>
        Payer,
    }
}