# SimpleCalc

Simple calculator project demonstrating unit testing with **xUnit** and **GitHub Actions CI/CD**.

## Quick Start

### Prerequisites
- .NET 10 SDK
- Git

### Run

dotnet restore dotnet build dotnet run --project SimpleCalc dotnet test

## Calculator Operations

var calc = new Calculator();
calc.Add(10, 5)        // 15 calc.Subtract(10, 5)   // 5 calc.Multiply(10, 5)   // 50 calc.Divide(10, 5)     // 2

## Tests

**8 unit tests** using xUnit with **AAA Pattern** (Arrange-Act-Assert):
- Addition, Subtraction, Multiplication, Division
- Negative numbers, Zero divisor handling
- Parameterized tests with multiple inputs

Run tests: `dotnet test`

## Project Structure

SimpleCalc/ ├── SimpleCalc/              # Main project ├── SimpleCalc.Tests/        # Unit tests ├── .github/workflows/dotnet.yml  # GitHub Actions └── README.md

## Technologies

- C# 14.0
- .NET 10
- xUnit 2.9.0
- GitHub Actions

## License

MIT
