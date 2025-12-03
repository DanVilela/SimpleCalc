namespace SimpleCalc;

public class Calculator
{
    public decimal Add(decimal a, decimal b) => a + b;

    public decimal Subtract(decimal a, decimal b) => a - b;

    public decimal Multiply(decimal a, decimal b) => a * b;

    public decimal Divide(decimal a, decimal b)
    {
        if (b == 0)
            throw new ArgumentException("Divisor cannot be zero", nameof(b));
        return a / b;
    }
}