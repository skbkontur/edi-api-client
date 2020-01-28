using System;

using SkbKontur.EdiApi.Client.Types.Internal.GoodItems;

namespace SkbKontur.EdiApi.Client.Types.Internal.DocumentSpecificFields
{
    public class InvoicFields : OrderBasedDocumentFields
    {
        public string RevisionNumber { get; set; }

        public DateTime? RevisionDate { get; set; }
        public string RevisionedInvoicDiadocId { get; set; }
        public DocumentRevisionType DocumentRevisionType { get; set; }
        public string MessageIdOfRevisionedInvoic { get; set; }

        public DateTime? ActualDeliveryDate { get; set; }

        public string OrderResponseNumber { get; set; }

        public DateTime? OrderResponseDate { get; set; }

        public string DespatchAdviceNumber { get; set; }

        public DateTime? DespatchDate { get; set; }

        public string ReceivingAdviceNumber { get; set; }

        public DateTime? ReceivingDate { get; set; }

        public string SpecificationNumber { get; set; }

        public DateTime? SpecificationDate { get; set; }

        public string GovernmentContractNumber { get; set; }
        public DateTime? GovernmentContractDate { get; set; }

        public string ProposalOrdersNumber { get; set; }
        public DateTime? ProposalOrdersDate { get; set; }

        public string ReceivingAdviceNumberInBuyerSystem { get; set; }

        public string CurrencyCode { get; set; }

        public decimal? InvoicTotal { get { return invoicTotal ?? invoicTaxableTotal; } set { invoicTotal = value; } }

        public decimal? InvoicTotalWithVAT { get; set; }

        public decimal? InvoicTotalVAT { get; set; }

        public decimal? InvoicTaxableTotal { get { return invoicTaxableTotal ?? invoicTotal; } set { invoicTaxableTotal = value; } }

        public decimal? InvoicTotalForDQ { get { return invoicTotalForDQ ?? invoicTaxableTotalForDQ; } set { invoicTotalForDQ = value; } }

        public decimal? InvoicTotalWithVATForDQ { get; set; }

        public decimal? InvoicTotalVATForDQ { get; set; }

        public decimal? InvoicTaxableTotalForDQ { get { return invoicTaxableTotalForDQ ?? invoicTotalForDQ; } set { invoicTaxableTotalForDQ = value; } }

        public decimal? InvoicTotalForIV { get { return invoicTotalForIV ?? invoicTaxableTotalForIV; } set { invoicTotalForIV = value; } }

        public decimal? InvoicTotalWithVATForIV { get; set; }

        public decimal? InvoicTotalVATForIV { get; set; }

        public decimal? InvoicTaxableTotalForIV { get { return invoicTaxableTotalForIV ?? invoicTotalForIV; } set { invoicTaxableTotalForIV = value; } }
        public decimal? InvoicTotalDiscount { get; set; }
        public decimal? InvoicTotalCharges { get; set; }
        public decimal? InvoicTotalPackingCost { get; set; }
        public Sg52[] TotalsSpecifiedForTax { get; set; }

        public TransportationCosts TransportationCosts { get; set; }

        public string TransportBy { get; set; }

        public string CustomerReferenceNumber { get; set; }

        public string FreeText { get; set; }
        public string FactoringEncription { get; set; }
        public CommonGoodItem[] GoodItems { get; set; }

        private decimal? invoicTotal;
        private decimal? invoicTaxableTotal;

        private decimal? invoicTotalForIV;
        private decimal? invoicTaxableTotalForIV;

        private decimal? invoicTotalForDQ;
        private decimal? invoicTaxableTotalForDQ;
    }

    public class Sg52
    {
        public string VATRate { get; set; }
        public string TypeNameCode { get; set; }
        public string FunctionalCodeQualifier { get; set; }
        public decimal? InvoicTotalForRate { get; set; }
        public decimal? InvoicTaxableTotalForRate { get; set; }
        public decimal? InvoicTotalVATForRate { get; set; }
    }

    public class TransportationCosts
    {
        public string VAT { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalVAT { get; set; }
        public decimal? TotalWithVAT { get; set; }
    }
}