namespace SkbKontur.EdiApi.Client.Types.Organization
{
    /// <summary>Реквизиты юридического лица</summary>
    public class ULInfo
    {
        /// <summary>ИНН</summary>
        public string Inn { get; set; }

        /// <summary>КПП</summary>
        public string Kpp { get; set; }

        /// <summary>Наименование</summary>
        public string Name { get; set; }
    }
}