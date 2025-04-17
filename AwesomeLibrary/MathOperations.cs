using System;
using System.Globalization;

namespace MyAwesomeLibrary
{
    /// <summary>
    /// Provides basic mathematical operations with support for multiple data types.
    /// </summary>
    public static class MathOperations
    {
        /// <summary>
        /// Adds two numbers.
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>The sum of the two numbers.</returns>
        public static double Add(double a, double b) => a + b;

        /// <summary>
        /// Adds two integers.
        /// </summary>
        /// <param name="a">The first integer.</param>
        /// <param name="b">The second integer.</param>
        /// <returns>The sum of the two integers.</returns>
        public static int Add(int a, int b) => a + b;

        /// <summary>
        /// Adds two numbers provided as strings.
        /// </summary>
        /// <param name="a">The first number as a string.</param>
        /// <param name="b">The second number as a string.</param>
        /// <returns>The sum of the two numbers.</returns>
        /// <exception cref="ArgumentException">Thrown when input strings cannot be parsed to numbers.</exception>
        public static double Add(string a, string b)
        {
            if (!double.TryParse(a, NumberStyles.Float, CultureInfo.InvariantCulture, out double num1) ||
                !double.TryParse(b, NumberStyles.Float, CultureInfo.InvariantCulture, out double num2))
                throw new ArgumentException("Invalid string format for numbers.");
            return num1 + num2;
        }

        /// <summary>
        /// Subtracts one number from another.
        /// </summary>
        /// <param name="a">The minuend.</param>
        /// <param name="b">The subtrahend.</param>
        /// <returns>The difference between the two numbers.</returns>
        public static double Subtract(double a, double b) => a - b;

        /// <summary>
        /// Subtracts one integer from another.
        /// </summary>
        /// <param name="a">The minuend.</param>
        /// <param name="b">The subtrahend.</param>
        /// <returns>The difference between the two integers.</returns>
        public static int Subtract(int a, int b) => a - b;

        /// <summary>
        /// Subtracts one number from another provided as strings.
        /// </summary>
        /// <param name="a">The minuend as a string.</param>
        /// <param name="b">The subtrahend as a string.</param>
        /// <returns>The difference between the two numbers.</returns>
        /// <exception cref="ArgumentException">Thrown when input strings cannot be parsed to numbers.</exception>
        public static double Subtract(string a, string b)
        {
            if (!double.TryParse(a, NumberStyles.Float, CultureInfo.InvariantCulture, out double num1) ||
                !double.TryParse(b, NumberStyles.Float, CultureInfo.InvariantCulture, out double num2))
                throw new ArgumentException("Invalid string format for numbers.");
            return num1 - num2;
        }

        /// <summary>
        /// Multiplies two numbers.
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>The product of the two numbers.</returns>
        public static double Multiply(double a, double b) => a * b;

        /// <summary>
        /// Multiplies two integers.
        /// </summary>
        /// <param name="a">The first integer.</param>
        /// <param name="b">The second integer.</param>
        /// <returns>The product of the two integers.</returns>
        public static int Multiply(int a, int b) => a * b;

        /// <summary>
        /// Multiplies two numbers provided as strings.
        /// </summary>
        /// <param name="a">The first number as a string.</param>
        /// <param name="b">The second number as a string.</param>
        /// <returns>The product of the two numbers.</returns>
        /// <exception cref="ArgumentException">Thrown when input strings cannot be parsed to numbers.</exception>
        public static double Multiply(string a, string b)
        {
            if (!double.TryParse(a, NumberStyles.Float, CultureInfo.InvariantCulture, out double num1) ||
                !double.TryParse(b, NumberStyles.Float, CultureInfo.InvariantCulture, out double num2))
                throw new ArgumentException("Invalid string format for numbers.");
            return num1 * num2;
        }

        /// <summary>
        /// Divides one number by another.
        /// </summary>
        /// <param name="a">The dividend.</param>
        /// <param name="b">The divisor.</param>
        /// <returns>The quotient of the division.</returns>
        /// <exception cref="DivideByZeroException">Thrown when the divisor is zero.</exception>
        public static double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException("Division by zero is not allowed.");
            return a / b;
        }

        /// <summary>
        /// Divides one integer by another.
        /// </summary>
        /// <param name="a">The dividend.</param>
        /// <param name="b">The divisor.</param>
        /// <returns>The quotient of the division.</returns>
        /// <exception cref="DivideByZeroException">Thrown when the divisor is zero.</exception>
        public static int Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException("Division by zero is not allowed.");
            return a / b;
        }

        /// <summary>
        /// Divides one number by another provided as strings.
        /// </summary>
        /// <param name="a">The dividend as a string.</param>
        /// <param name="b">The divisor as a string.</param>
        /// <returns>The quotient of the division.</returns>
        /// <exception cref="ArgumentException">Thrown when input strings cannot be parsed to numbers.</exception>
        /// <exception cref="DivideByZeroException">Thrown when the divisor is zero.</exception>
        public static double Divide(string a, string b)
        {
            if (!double.TryParse(a, NumberStyles.Float, CultureInfo.InvariantCulture, out double num1) ||
                !double.TryParse(b, NumberStyles.Float, CultureInfo.InvariantCulture, out double num2))
                throw new ArgumentException("Invalid string format for numbers.");
            if (num2 == 0) throw new DivideByZeroException("Division by zero is not allowed.");
            return num1 / num2;
        }

        /// <summary>
        /// Raises a number to the specified power.
        /// </summary>
        /// <param name="baseNum">The base number.</param>
        /// <param name="exponent">The exponent.</param>
        /// <returns>The result of raising baseNum to the power of exponent.</returns>
        /// <exception cref="ArgumentException">Thrown when baseNum is zero and exponent is negative.</exception>
        public static double Power(double baseNum, double exponent)
        {
            if (exponent == 0) return 1.0;
            if (baseNum == 0 && exponent < 0)
                throw new ArgumentException("Zero cannot be raised to a negative power.");

            bool isNegative = exponent < 0;
            exponent = isNegative ? -exponent : exponent;

            double result = 1.0;
            int intPart = (int)exponent;
            double fracPart = exponent - intPart;

            // Handle the integer part
            for (int i = 0; i < intPart; i++)
            {
                result *= baseNum;
            }

            // Handle the fractional part using a simple approximation
            if (fracPart != 0)
            {
                // For simplicity, use an iterative approximation for fractional exponents
                double temp = 1.0;
                for (int i = 0; i < 10; i++) // 10 iterations for approximation
                {
                    temp *= (baseNum * fracPart / (i + 1)) + (1 - fracPart);
                }
                result *= temp;
            }

            return isNegative ? 1.0 / result : result;
        }

        /// <summary>
        /// Raises an integer to the specified integer power.
        /// </summary>
        /// <param name="baseNum">The base integer.</param>
        /// <param name="exponent">The exponent.</param>
        /// <returns>The result of raising baseNum to the power of exponent.</returns>
        /// <exception cref="ArgumentException">Thrown when baseNum is zero and exponent is negative.</exception>
        public static int Power(int baseNum, int exponent)
        {
            if (exponent == 0) return 1;
            if (baseNum == 0 && exponent < 0)
                throw new ArgumentException("Zero cannot be raised to a negative power.");

            bool isNegative = exponent < 0;
            exponent = isNegative ? -exponent : exponent;

            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNum;
            }

            // Convert to double for negative exponent to avoid integer division issues
            if (isNegative)
            {
                double doubleResult = 1.0 / result;
                return doubleResult == 0 ? 0 : (int)doubleResult;
            }

            return result;
        }

        /// <summary>
        /// Raises a number to the specified power provided as strings.
        /// </summary>
        /// <param name="baseNum">The base number as a string.</param>
        /// <param name="exponent">The exponent as a string.</param>
        /// <returns>The result of raising baseNum to the power of exponent.</returns>
        /// <exception cref="ArgumentException">Thrown when input strings cannot be parsed to numbers.</exception>
        public static double Power(string baseNum, string exponent)
        {
            if (!double.TryParse(baseNum, NumberStyles.Float, CultureInfo.InvariantCulture, out double num1) ||
                !double.TryParse(exponent, NumberStyles.Float, CultureInfo.InvariantCulture, out double num2))
                throw new ArgumentException("Invalid string format for numbers.");
            return Power(num1, num2);
        }

        /// <summary>
        /// Calculates the square root of a number using Newton's method.
        /// </summary>
        /// <param name="number">The number to find the square root of.</param>
        /// <returns>The square root of the number.</returns>
        /// <exception cref="ArgumentException">Thrown when the number is negative.</exception>
        public static double SquareRoot(double number)
        {
            if (number < 0) throw new ArgumentException("Square root of a negative number is not defined.");
            if (number == 0) return 0;

            double guess = number / 2.0;
            double epsilon = 0.0000001;

            while (true)
            {
                double newGuess = (guess + number / guess) / 2.0;
                if ((guess - newGuess) < epsilon && (guess - newGuess) > -epsilon)
                    return newGuess;
                guess = newGuess;
            }
        }

        /// <summary>
        /// Calculates the square root of an integer using Newton's method.
        /// </summary>
        /// <param name="number">The integer to find the square root of.</param>
        /// <returns>The square root of the integer.</returns>
        /// <exception cref="ArgumentException">Thrown when the number is negative.</exception>
        public static double SquareRoot(int number)
        {
            return SquareRoot((double)number);
        }

        /// <summary>
        /// Calculates the square root of a number provided as a string using Newton's method.
        /// </summary>
        /// <param name="number">The number as a string.</param>
        /// <returns>The square root of the number.</returns>
        /// <exception cref="ArgumentException">Thrown when the input string cannot be parsed or is negative.</exception>
        public static double SquareRoot(string number)
        {
            if (!double.TryParse(number, NumberStyles.Float, CultureInfo.InvariantCulture, out double num))
                throw new ArgumentException("Invalid string format for number.");
            return SquareRoot(num);
        }
    }
}