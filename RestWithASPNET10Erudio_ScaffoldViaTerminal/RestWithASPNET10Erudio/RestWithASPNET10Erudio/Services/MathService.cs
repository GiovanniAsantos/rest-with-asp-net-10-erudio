namespace RestWithASPNET10Erudio.Services;

public class MathService
{
    public decimal Sum(decimal firstNumber, decimal secondNumber)
    {
        return firstNumber + secondNumber;
    }
    
    public decimal Sub(decimal firstNumber, decimal secondNumber)
    {
        return firstNumber - secondNumber;
    }
    
    public decimal Div(decimal firstNumber, decimal secondNumber)
    {
        if(secondNumber == 0) throw new DivideByZeroException("Division by zero is not allowed.");
        return firstNumber / secondNumber;
    }
    
    public decimal Mult(decimal firstNumber, decimal secondNumber)
    {
        return firstNumber * secondNumber;
    }
    
    public decimal Media(decimal firstNumber, decimal secondNumber)
    {
        return (firstNumber + secondNumber) / 2;
    }

    public decimal Raiz(decimal firstNumber)
    {
        if(firstNumber < 0) throw new ArgumentException("Cannot calculate the square root of a negative number.");
        return (decimal)Math.Sqrt((double)firstNumber);
    }
}