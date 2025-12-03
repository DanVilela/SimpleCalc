using SimpleCalc;

var calculator = new Calculator();

Console.WriteLine("=== Simple Calculator ===\n");

Console.WriteLine($"10 + 5 = {calculator.Add(10, 5)}");
Console.WriteLine($"10 - 5 = {calculator.Subtract(10, 5)}");
Console.WriteLine($"10 * 5 = {calculator.Multiply(10, 5)}");
Console.WriteLine($"10 / 5 = {calculator.Divide(10, 5)}");

Console.WriteLine("\nCalculator ready!");
