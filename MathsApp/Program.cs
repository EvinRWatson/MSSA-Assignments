using System;

namespace MathsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input + Format Exception
            Console.WriteLine("Which type of operation would you like to perform" +
                                "\nMulitplication - 'm'" +
                                "\nDivsion - 'd'" +
                                "\nAddition - 'a'" +
                                "\nSubraction - 's'");
            string operatorType = Console.ReadLine();
            double num1 = 0, num2 = 0;

            try
            {
                Console.WriteLine("Number 1: ");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Number 2: ");
                num2 = double.Parse(Console.ReadLine());
            }
            catch (FormatException fEx)
            {
                Console.WriteLine("Input(s) is not a number");
            }

            // Select the type of operation based off input
            switch (operatorType)
            {
                case "m": //Multiply
                    Console.WriteLine($"{num1} * {num2} = {Multiply(num1, num2)}");
                    break;
                case "d": //Divide
                    while (num1 == 0)
                    {
                        Console.WriteLine($"Input a new value in place of {num1}");
                        num1 = double.Parse(Console.ReadLine());
                    }
                    while (num2 == 0)
                    {
                        Console.WriteLine($"Input a new value in place of {num2}");
                        num2 = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine($"{num1} / {num2} = {Divide(num1, num2)}");
                    break;
                case "a": //Addition
                    Console.WriteLine($"{num1} + {num2} = {Add(num1, num2)}");
                    break;
                case "s": //Subtraction
                    Console.WriteLine($"{num1} - {num2} = {Subtract(num1, num2)}");
                    break;
                default: //No Operator
                    Console.WriteLine("Thanks for stopping by!");
                    break;
            }
        }

        // Methods
        static double Multiply(double num1, double num2) => num1 * num2;
        static double Divide(double num1, double num2) => num1 / num2;
        static double Add(double num1, double num2) => num1 + num2;
        static double Subtract(double num1, double num2) => num1 - num2;
    }
}
