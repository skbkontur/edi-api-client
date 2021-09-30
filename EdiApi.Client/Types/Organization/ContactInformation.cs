namespace SkbKontur.EdiApi.Client.Types.Organization
{
    /// <summary>Контактная информация</summary>
    public class ContactInformation
    {
        /// <summary>ФИО</summary>
        public string Name { get; set; }

        /// <summary>Номер телефона</summary>
        public string Phone { get; set; }

        /// <summary>Факс</summary>
        public string Fax { get; set; }

        /// <summary>Email</summary>
        public string Email { get; set; }
    }
}