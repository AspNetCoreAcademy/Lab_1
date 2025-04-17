# MyAwesomeLibrary

A powerful and flexible .NET library for performing mathematical operations with support for multiple data types (double, int, string). It provides basic arithmetic operations, power, and square root calculations, designed for ease of use and reliability.

## Installation

Install the `MyAwesomeLibrary` NuGet package using the .NET CLI:

```bash
dotnet add package ShkutMyAwesomeLibrary --version 1.0.0
```

Or via the NuGet Package Manager in Visual Studio.

## Features

- **Basic Arithmetic**: Addition, subtraction, multiplication, and division.
- **Advanced Operations**: Power and square root calculations.
- **Type Flexibility**: Overloads for `double`, `int`, and `string` inputs.
- **Error Handling**: Robust exception handling for invalid inputs (e.g., division by zero, negative square roots).
- **Documentation**: XML comments for all methods, integrated with IntelliSense.

## Usage

Below is an example demonstrating how to use `MyAwesomeLibrary` in a console application:

```csharp
using MyAwesomeLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MyAwesomeLibrary Demo!");
            Console.WriteLine("Addition (2.5 + 2.5): " + MathOperations.Add(2.5, 2.5));          // 5
            Console.WriteLine("Subtraction (5.0 - 2.0): " + MathOperations.Subtract(5.0, 2.0)); // 3
            Console.WriteLine("Multiplication (3.0 * 2.0): " + MathOperations.Multiply(3.0, 2.0)); // 6
            Console.WriteLine("Division (6.0 / 3.0): " + MathOperations.Divide(6.0, 3.0));     // 2
            Console.WriteLine("Power (2.0 ^ 3.0): " + MathOperations.Power(2.0, 3.0));         // 8
            Console.WriteLine("Square Root (16.0): " + MathOperations.SquareRoot(16.0));       // 4

            // Working with strings
            Console.WriteLine("\nWorking with strings:");
            Console.WriteLine("Addition (\"2.5\" + \"2.5\"): " + MathOperations.Add("2.5", "2.5")); // 5
            Console.WriteLine("Power (\"2.0\" ^ \"3.0\"): " + MathOperations.Power("2.0", "3.0")); // 8
        }
    }
}
```

### Output
```
Welcome to MyAwesomeLibrary Demo!
Addition (2.5 + 2.5): 5
Subtraction (5.0 - 2.0): 3
Multiplication (3.0 * 2.0): 6
Division (6.0 / 3.0): 2
Power (2.0 ^ 3.0): 8
Square Root (16.0): 4

Working with strings:
Addition ("2.5" + "2.5"): 5
Power ("2.0" ^ "3.0"): 8
```

## Supported Operations

| Operation       | Description                              | Supported Types         |
|-----------------|------------------------------------------|-------------------------|
| `Add`           | Adds two numbers or parses strings       | `double`, `int`, `string` |
| `Subtract`      | Subtracts the second number from the first | `double`, `int`, `string` |
| `Multiply`      | Multiplies two numbers                   | `double`, `int`, `string` |
| `Divide`        | Divides the first number by the second   | `double`, `int`, `string` |
| `Power`         | Raises the first number to the second     | `double`, `int`, `string` |
| `SquareRoot`    | Calculates the square root using Newton's method | `double`, `int`, `string` |

## Error Handling

- **Division by Zero**: Throws `DivideByZeroException`.
- **Negative Square Root**: Throws `ArgumentException`.
- **Invalid String Inputs**: Throws `ArgumentException` if strings cannot be parsed to numbers.

## Requirements

- .NET 9.0 or later
