namespace SkbKontur.EdiApi.Client.Types.Common
{
    /// <summary>Статус GLN</summary>
    public enum GlnStatus
    {
        /// <summary>Действующий</summary>
        Valid,

        /// <summary>Срок действия истек</summary>
        Invalid,

        /// <summary>Этот GLN выдан другой организации</summary>
        GlnIssuedForAnotherInn,
    }
}