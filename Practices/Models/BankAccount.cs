namespace Practices.Models;

public class BankAccount
{
    public double Balance { get; private set; }

    private List<Transaction> transactions = new List<Transaction>();

    public BankAccount()
    {
        // Set the account initial balance
        Balance = 0;

        // Save account opening movement
        transactions.Add(new Transaction("Account Created", 0, Balance));
    }

    public void Deposit(double amount)
    {
        // Validate amount before depositing
        if (amount <= 0)
        {
            Console.WriteLine("Invalid deposit amount");
            return;
        }

        Balance += amount;

        // Save deposit movement
        transactions.Add(new Transaction("Deposit", amount, Balance));
    }

    public void Withdraw(double amount)
    {
        // Validate amount before withdrawing
        if (amount <= 0)
        {
            Console.WriteLine("Invalid withdrawal amount");
            return;
        }

        // Validate available balance
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient balance");
            return;
        }

        Balance -= amount;

        // Save withdrawal movement
        transactions.Add(new Transaction("Withdrawal", amount, Balance));
    }
}