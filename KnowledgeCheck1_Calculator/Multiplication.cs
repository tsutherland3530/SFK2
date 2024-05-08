using System;
using System.Diagnostics;

namespace KnowledgeCheck1_Calculator
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    class Program
    {
        private static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            Console.WriteLine("Enter 2 numbers:");
            var number1 = Console.ReadLine();
            var number2 = Console.ReadLine();

            switch (input)
            {
                case "1":
                    PerformOperation(number1, number2, calculator.Add);
                    break;
                case "2":
                    PerformOperation(number1, number2, calculator.Subtract);
                    break;
                case "3":
                    PerformOperation(number1, number2, calculator.Multiply);
                    break;
                case "4":
                    PerformOperation(number1, number2, calculator.Divide, isDivision: true);
                    break;
                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }

        static void PerformOperation(string input1, string input2, Func<double, double, double> operation, bool isDivision = false)
        {
            if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2))
            {
                if (isDivision && num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return;
                }
                Console.WriteLine($"Result: {operation(num1, num2)}");
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not a valid number.");
            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }

    class Calculator
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b) => b == 0 ? double.NaN : a / b; // Just in case, added a safety check here too.
    }
}
