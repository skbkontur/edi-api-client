namespace KonturEdi.Api.Types.Organization
{
    public class PartyInformation
    {
        public string Gln { get; set; }

        public PartyAddress PartyAddress { get; set; }
        public RussianPartyInfo RussianPartyInfo { get; set; }

        public BankAccount BankAccount { get; set; }

        public string SupplierCodeInBuyerSystem { get; set; }
        public ContactInformation Chief { get; set; } // Руководитель
        public ContactInformation Bookkeeper { get; set; } // Главный бухгалтер
        public ContactInformation SalesAdministration { get; set; }

        public ContactInformation OrderContact { get; set; } //Контактное лицо по заказу
    }
}