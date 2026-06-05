namespace Practices.Models;

public class Calc
{
    private int firstNumber;
    private int secondNumber;

    public Calc(int firstNumber, int secondNumber)
    {
        this.firstNumber = firstNumber;
        this.secondNumber = secondNumber;
    }
    
    public int CalculateOdd()
    {
        int result = firstNumber % secondNumber;
        Console.WriteLine("Your odd result is:");
        return result;
    }
}