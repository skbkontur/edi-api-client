using System;

using SkbKontur.EdiApi.Types.Internal.GoodItems;

namespace SkbKontur.EdiApi.Types.Internal.DocumentSpecificFields
{
    public class AlcrptFields : OrderBasedDocumentFields
    {
        public DocumentRevisionType DocumentRevisionType { get; set; }

        public string OriginOrderNumber { get; set; }
        public DateTime? OriginOrderDate { get; set; }

        public string CustomDeclarationNumber { get; set; }
        public DateTime? CustomDeclarationDate { get; set; }

        public string ReceivingAdviceNumber { get; set; }
        public DateTime? ReceivingDate { get; set; }

        public string DespatchAdviceNumber { get; set; }
        public DateTime? DespatchDate { get; set; }

        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }

        public string CarrierGln { get; set; }

        public Transportation Transportation { get; set; }

        public AlcrptGoodItem[] GoodItems { get; set; }
    }

    public class Transportation
    {
        public string TransportMode { get; set; }
        public string TransportIdentificator { get; set; }
        public string TypeOfTransport { get; set; }
        public string VehicleCapacity { get; set; }
    }
}