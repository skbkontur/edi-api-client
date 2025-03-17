#nullable enable

namespace SkbKontur.EdiApi.Client.Types.Logistics
{
    /// <summary>УИД транспортной накладной из пула Минтранс</summary>
    public class GlobalTransportationIdentifier
    {
        /// <summary>Значение УИДа транспортной накладной</summary>
        public string Id { get; set; } = null!;
    }
}