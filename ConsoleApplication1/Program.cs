using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Error! Invalid input for the first number.");
                return;
            }

            Console.WriteLine("Enter the second number:");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Error! Invalid input for the second number.");
                return;
            }

            Console.WriteLine("Enter the operator (&, |, ^):");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int result;

            switch (operation)
            {
                case '&':
                    result = a & b;
                    break;
                case '|':
                    result = a | b;
                    break;
                case '^':
                    result = a ^ b;
                    break;
                default:
                    Console.WriteLine("Error! Invalid operator.");
                    return;
            }

            Console.WriteLine($"Result in decimal: {result}");
            Console.WriteLine($"Result in binary: {Convert.ToString(result, 2)}");
            Console.WriteLine($"Result in hexadecimal: {Convert.ToString(result, 16).ToUpper()}");
        }
    }
}