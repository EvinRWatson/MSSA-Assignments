using System;
using System.Diagnostics;
using System.Threading;

namespace PasswordCracker
{
    class Program
    {
        public static bool complete = false;
        public static long iterations = 0;
        public static string Password;
        public static Stopwatch timer = new Stopwatch();
        static void Main(string[] args)
        {
            //User Input
            Console.WriteLine("Please enter your password:");
            Password = Console.ReadLine();

            //Start Timer
            timer.Start();

            //Initializing Threads
            Console.WriteLine("...Working...");
            Thread thread1 = new Thread(() => Generate(String.Empty));
            Thread thread2 = new Thread(() => GenerateBackward(String.Empty));

            //Completing The Operation
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();

            //Stop Timer
            timer.Stop();

            //Output
            TimeSpan totalTime = timer.Elapsed;
            Console.WriteLine($"Total Iterations:\t{iterations}");
            Console.WriteLine("Total Time:\t\t" + String.Format("{0:00}:{1:00}:{2:00}.{3:00}", totalTime.Hours, totalTime.Minutes, totalTime.Seconds, totalTime.Milliseconds / 10));
        }

        //Generate password starting from low-high ASCII characters
        public static void Generate(string input)
        {
            iterations++;
            if (input == Password)
            {
                complete = true;
                return;
            }

            char temp = ' ';

            // Adds temporary character with each iteration -- Going forwards based on ASCII values
            for (int i = 32; i <= 126; i++)
            {
                if (complete == true || input.Length >= Password.Length) //Ensures that there is no runaway recursion
                    return;
                temp = (char)i;
                Generate(input + temp);
            }
        }

        //Generate password starting from high-low ASCII characters
        public static void GenerateBackward(string input)
        {
            iterations++;
            char temp = ' ';

            // Returns if password matches
            if (input == Password)
            {
                complete = true;
                return;
            }

            // Adds temporary character with each iteration -- Going backwards based on ASCII values
            for (int i = 126; i >= 32; i--)
            {
                if (complete == true || input.Length >= Password.Length) //Ensures that there is no runaway recursion
                    return;
                temp = (char)i;
                GenerateBackward(input + temp);
            }
        }
    }
}
