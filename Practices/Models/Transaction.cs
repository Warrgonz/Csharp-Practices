namespace Practices.Models;

public class Transaction
{
    public string Type { get; private set; }
    public double Amount { get; private set; }
    public double BalanceAfterTransaction { get; private set; }
    public DateTime Date { get; private set; }

    public Transaction(string type, double amount, double balanceAfterTransaction)
    {
        Type = type;
        Amount = amount;
        BalanceAfterTransaction = balanceAfterTransaction;
        Date = DateTime.Now;
    }
}