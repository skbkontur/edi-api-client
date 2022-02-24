namespace SkbKontur.EdiApi.Client.Types.Organization
{
    /// <summary>Банковские реквизиты</summary>
    public class BankAccount
    {
        /// <summary>Расчётный счёт</summary>
        public string BankAccountNumber { get; set; }

        /// <summary>Корр. счёт</summary>
        public string CorrespondentAccountNumber { get; set; }

        /// <summary>БИК банка</summary>
        public string BankId { get; set; }

        /// <summary>Наименование банка</summary>
        public string BankName { get; set; }
    }
}