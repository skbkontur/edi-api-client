#nullable enable

namespace SkbKontur.EdiApi.Client.Types.Logistics
{
    /// <summary>УИД транспортного документа из пула Минтранс</summary>
    public class TransportationDocumentIdentifier
    {
        /// <summary>Значение УИДа транспортного документа</summary>
        public string Id { get; set; } = null!;
    }
}