using Practices.Models;

namespace Practices;

public class program
{
    public static void Main(string[] args)
    {
        // Es decir, veamolo como un contrato donde cada vez que alguien cree una cuenta bancaria, ya tiene values que tiene que pasarle.
    
        // Ejemplo practico:
        BankAccount micuenta_11892315 = new BankAccount(1, "Warren", "Gonzalez", 5000);

        Console.WriteLine("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Calc calcularImpar = new Calc(firstNumber, secondNumber);
        
        Console.WriteLine(calcularImpar.CalculateOdd());
        
        // Short cw = Console.WriteLine()
    }
}