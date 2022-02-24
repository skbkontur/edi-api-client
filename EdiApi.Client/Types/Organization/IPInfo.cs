namespace SkbKontur.EdiApi.Client.Types.Organization
{
    /// <summary>Реквизиты физического лица</summary>
    public class IPInfo
    {
        /// <summary>ИНН</summary>
        public string Inn { get; set; }

        /// <summary>Имя</summary>
        public string FirstName { get; set; }

        /// <summary>Отчество</summary>
        public string MiddleName { get; set; }

        /// <summary>Фамилия</summary>
        public string LastName { get; set; }
    }
}