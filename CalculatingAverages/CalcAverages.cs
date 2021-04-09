using System;

namespace CalculatingAverages
{
    class CalcAverages
    {
        static void Main(string[] args)
        {
            //Uncomment Which portion you would like to test

            Console.WriteLine("Sum:\t" + SumOfTenNumbers());                      //Sum of numbers


            //AverageTenScores();                                                   //Average ten scores


            //Console.WriteLine("How many assignments will you grade?");            //Average a specific number of scores
            //AveragesSpecScores(int.Parse(Console.ReadLine()));                                                


            //AverageNonSpecScores();                                               //Average a non-specific number of scores

        }

        public static string getLetterGrade(double grade)    //Retrieve string letter grade from type double grade
        {
            string letterGrade = null;
            if (grade >= 90)
                letterGrade = "A";
            else if (grade < 90 && grade >= 80)
                letterGrade = "B";
            else if (grade < 80 && grade >= 70)
                letterGrade = "C";
            else
                letterGrade = "F";
            return letterGrade;
        }
        

        static int SumOfTenNumbers()                                //Sum of numbers
        {
            int x = 10;
            int sum = 0;
            Console.WriteLine("Input 10 numbers, each followed by a Enter:");
            while (x > 0)
            {
                int input = int.Parse(Console.ReadLine());
                if (input <= 100 && input >= 0) 
                {
                    sum += input;
                    x--;
                }
            }
            string stringSum = sum.ToString();
            return sum;
        }

        private static void AverageTenScores()                      //Average ten scores
        {
            double avgGrade = SumOfTenNumbers() / 10;
            string letterGrade = getLetterGrade(avgGrade);
            Console.WriteLine($"Letter Grade is: {letterGrade}, with a average grade of {avgGrade}");
        }

        private static void AveragesSpecScores(int numScores)       //Average a specific number of scores
        {
            int sum = 0;
            int x = numScores;
            Console.WriteLine($"Input {numScores} numbers, each followed by a Enter:");
            while (x > 0)
            {
                int input = int.Parse(Console.ReadLine());
                if (input <= 100 && input >= 0)
                {
                    sum += input;
                    x--;
                }
            }
            double avgScore = sum / numScores;
            string letterGrade = getLetterGrade(avgScore);
            Console.WriteLine($"The {numScores} assignments turned out to be a {letterGrade}, with an average of {avgScore}");
        }

        private static void AverageNonSpecScores()                  //Average a non-specific number of scores
        {
            int sum = 0;
            int numOfGrades = 0;
            double avgGrade = 0;
            string letterGrade = "No Grade";
            while (true)
            {
                Console.WriteLine($"Input Grade, Current grade is a {letterGrade} with an average score of {avgGrade} ");
                int input = int.Parse(Console.ReadLine());
                if (input <= 100 && input >= 0)
                {
                    sum += input;
                    numOfGrades++;
                    avgGrade = sum / numOfGrades;
                    letterGrade = getLetterGrade(avgGrade);
                }
                else
                    Console.WriteLine("Invalid Input");
            }
        }

    }
}
