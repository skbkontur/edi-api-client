namespace KonturEdi.Api.Types.Organization
{
    public class PartyInfo
    {
        public string Gln { get; set; }

        public PartyAddress PartyAddress { get; set; }
        public RussianPartyInfo RussianPartyInfo { get; set; }

        public BankAccount BankAccount { get; set; }

        public string SupplierCodeInBuyerSystem { get; set; }
        public ContactInformation Chief { get; set; }
        public ContactInformation Bookkeeper { get; set; }
        public ContactInformation SalesAdministration { get; set; }

        public ContactInformation OrderContact { get; set; }

        public string LocalizationType { get; set; }
    }
}