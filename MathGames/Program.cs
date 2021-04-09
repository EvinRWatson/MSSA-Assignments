using System;

namespace MathGames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Math Games");
            int probType = 0;
            int numProb = 0;
            int score = 0;
            Console.WriteLine("Choose Problem Type:\n\t1 - Addition\n\t2 - Subtraction\n\t3 - Multiplication\n\t4 - Division");
            probType = int.Parse(Console.ReadLine());
            Console.WriteLine("How many problems?");
            numProb = int.Parse(Console.ReadLine());

            switch (probType)
            { 
                case 1:
                    score = Util.Add(numProb);
                    break;
                case 2:
                    score = Util.Subtract(numProb);
                    break;
                case 3:
                    score = Util.Multiply(numProb);
                    break;
                case 4:
                    score = Util.Divide(numProb);
                    break;
                default:
                    Console.WriteLine("Sorry, you made an invalid choice.");
                        break;
            }
            string report = Util.Report(score, numProb);
            Console.WriteLine(report);
        }
    }

    public class Util
    {
        static Random rand = new Random();

        //  I removed initialize because it was useless
        public static string Report(int score, int numProb)
        {
            return $"You got {score} questions right with a grade of {(score/numProb) * 100}%";
        }

        public static int Add(int numProb)
        {
            int correctAnswer = 0;
            int score = 0;
            for (int i = 0; i < numProb; i++)
            {
                int Num1 = rand.Next(12);
                int Num2 = rand.Next(12);
                correctAnswer = Num1 + Num2;
                Console.WriteLine($"What is {Num1} + {Num2}?");
                int input = int.Parse(Console.ReadLine());
                if (input == correctAnswer)
                    score++;
            }
            return score;
        }

        public static int Subtract(int numProb)
        {
            int correctAnswer = 0;
            int score = 0;
            for (int i = 0; i < numProb; i++)
            {
                int Num1 = rand.Next(12);
                int Num2 = rand.Next(12);
                correctAnswer = Num1 - Num2;
                Console.WriteLine($"What is {Num1} - {Num2}?");
                int input = int.Parse(Console.ReadLine());
                if (input == correctAnswer)
                    score++;
            }
            return score;
        }

        public static int Multiply(int numProb)
        {
            int correctAnswer = 0;
            int score = 0;
            for (int i = 0; i < numProb; i++)
            {
                int Num1 = rand.Next(12);
                int Num2 = rand.Next(12);
                correctAnswer = Num1 * Num2;
                Console.WriteLine($"What is {Num1} * {Num2}?");
                int input = int.Parse(Console.ReadLine());
                if (input == correctAnswer)
                    score++;
            }
            return score;
        }
        public static int Divide(int numProb)
        {
            double correctAnswer = 0;
            int score = 0;
            for (int i = 0; i < numProb; i++)
            {
                int Num1 = rand.Next(12);
                int Num2 = rand.Next(12);
                correctAnswer = Num1 / Num2;
                Console.WriteLine($"What is {Num1} / {Num2}?");
                double input = double.Parse(Console.ReadLine());
                if (input == correctAnswer)
                    score++;
            }
            return score;
        }
    }
}
