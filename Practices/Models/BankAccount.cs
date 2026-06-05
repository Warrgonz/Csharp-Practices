namespace Practices.Models;

public class BankAccount
{
    private int id;
    private string name;
    private string lastName;
    private int balance;
    private char area = 'a';
    private const double percentVat = 15;
    
    // Utilidad del constructor: inicializar un objeto ya creado.
    public BankAccount(int id, string name, string lastName, int balance)
    {
        this.id = id;
        this.name = name;
        this.lastName = lastName;
        this.balance = balance;
    }

    public double CalculateVat()
    {
        return balance * percentVat;
    }
    



}