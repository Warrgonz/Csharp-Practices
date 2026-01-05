namespace Practices.TiposClases;

// Esto en vez de DomainModel, es BankAccount
public class DomainModel
{
    /*
     * Las clases Domain Model se caracterizan por:
     * Tienen identidad
     * TIenen estado
     * Tienen Comportamiento
     */

    private decimal balance;
    
    // Constructor
    public DomainModel(decimal initialBalance)
    {
        balance = initialBalance;
    }
    
    public decimal GetBalance()
    {
        return balance;
    }

    public void SetBalance(decimal newBalance)
    {
        balance = newBalance;
    }
}