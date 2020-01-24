using System;

namespace KonturEdi.Api.Types.Internal.GoodItems
{
    public class AlcrptGoodItem : GoodItemBase
    {
        public long? OrderLineNumber { get; set; }
        public Lot[] Lots { get; set; }
    }

    public class Lot
    {
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public string SignOfAlco { get; set; }
        public string CodeOfEgais { get; set; }
        public string LotNumberEgais { get; set; }
        public decimal? VolumeOfUnitInLiter { get; set; }
        public Volume Volume { get; set; }
        public DateTime? BottlingDate { get; set; }
        public Certificate Certificate { get; set; }
        public string ManufacturerGln { get; set; }
        public string ForeignManufacturerGln { get; set; }
        public LicenseSeller LicenseSeller { get; set; }

        public string[] CustomDeclarationNumbers { get; set; }

        public string[] CountriesOfOriginCode { get; set; }
    }

    public class Volume
    {
        public Quantity DespatchVolume { get; set; }
        public Quantity OrderedVolume { get; set; }
        public Quantity AcceptedVolume { get; set; }
    }

    public class Certificate
    {
        public string Number { get; set; }
        public DateTime? StartDate { get; set; } //TODO вопросик это хрень какая-то, поле вроде как обязательное вседа
        public DateTime? EndDate { get; set; } //TODO вопросик это хрень какая-то, поле вроде как обязательное вседа
        public string IssuerOf { get; set; }
    }

    public class LicenseSeller
    {
        public string SeriesNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string IssuerOf { get; set; }
    }
}