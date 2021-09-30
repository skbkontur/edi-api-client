namespace SkbKontur.EdiApi.Client.Types.Organization
{
    /// <summary>Российский адрес</summary>
    public class RussianAddressInfo
    {
        /// <summary>Почтовый индекс</summary>
        public string PostalCode { get; set; }
        /// <summary>Код региона в формате ISO</summary>
        public string RegionCode { get; set; }
        /// <summary>Район</summary>
        public string District { get; set; }
        /// <summary>Город</summary>
        public string City { get; set; }
        /// <summary>Населённый пункт</summary>
        public string Village { get; set; }
        /// <summary>Улица</summary>
        public string Street { get; set; }
        /// <summary>Дом</summary>
        public string House { get; set; }
        /// <summary>Корпус</summary>
        public string Block { get; set; }
        /// <summary>Квартира/офис</summary>
        public string Flat { get; set; }
    }
}