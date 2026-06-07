using Practices.Models;

namespace Practices;

public class program
{
    public static void Main(string[] args)
    {
        // Es decir, veamolo como un contrato donde cada vez que alguien cree una cuenta bancaria, ya tiene values que tiene que pasarle.
    
        // Inicializo el objeto
        BankAccount micuenta_11892315 = new BankAccount();

        Console.WriteLine("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Calc calcularImpar = new Calc(firstNumber, secondNumber);
        
        Console.WriteLine(calcularImpar.CalculateOdd());
        
        Console.WriteLine("Enter amount to deposit:");

        double amount = double.Parse(Console.ReadLine());
        
        micuenta_11892315.Deposit(amount);
        micuenta_11892315.Withdraw(amount);
        
        // Short cw = Console.WriteLine()
    }
}