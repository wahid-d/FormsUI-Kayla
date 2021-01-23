using System;
namespace formsUI.Models
{
    public class Transaction
    {
        public double Amount { get; set; }
        public string Note { get; set; }
        public TransactionType Type { get; set; }
    }

    public enum TransactionType
    {
        Sent,
        Received,
        Loan,
        Savings
    }
}
