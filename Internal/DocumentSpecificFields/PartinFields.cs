namespace KonturEdi.Api.Types.Internal.DocumentSpecificFields
{
    public class PartinFields
    {
        public string OwnerId { get; set; }

        public Organization.Organization[] BuyersOrPayers { get; set; }
        public Organization.Organization[] ShippersOrConsignees { get; set; }
    }
}