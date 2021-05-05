using System;
using System.Collections.Generic;

namespace LinearRegression
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adding Data
            Position Andre = new Position(165, 66);
            Position Aaron = new Position(185, 71);
            Position James = new Position(190, 70);
            Position Charles = new Position(210, 72);
            Position Jacon = new Position(180, 72);
            Position Kindra = new Position(150, 67);
            Position Malachi = new Position(180, 68);

            //User Interaction
            Console.WriteLine("The forumula for the inputed data model is:");
            Console.WriteLine($"Y = {Position.getAlpha()} + {Position.getBeta()} * X");

            //Taking in predictor variable
            Console.WriteLine("Please enter a value for X as a predictor:");
            double X = double.Parse(Console.ReadLine());

            //Calculating and output data
            double result = X * Position.getBeta() + Position.getAlpha();
            Console.WriteLine($"The result of X of {X} Y is {result}.");

        }
    }

    class Position
    {
        //Storing positions in a list so its easier to operate on
        public static List<Position> PositionList = new List<Position>();

        // Properties
        public double X { get; set; }
        public double Y { get; set; }

        //Constructors
        public Position()
        {
            this.X = 0.0;
            this.Y = 0.0;
            PositionList.Add(this);
        }
        public Position(double X = 0, double Y = 0)
        {
            this.X = X;
            this.Y = Y;
            PositionList.Add(this);
        }
        public Position(int X = 0, int Y = 0)
        {
            this.X = X;
            this.Y = Y;
            PositionList.Add(this);
        }

        //Equations
        public static double getAlpha() => (sumY() * sumXSquared() - sumX() * sumXY())
                                        / (getN() * sumXSquared() - Math.Pow(sumX(), 2));

        public static double getBeta() => (getN() * sumXY() - sumX() * sumY())
                                        / (getN() * sumXSquared() - (Math.Pow(sumX(), 2)));

        //Summation Functions
        public static double sumX()
        {
            double sum = 0;
            foreach (Position item in PositionList)
                sum += item.X;
            return sum;
        }
        public static double sumY()
        {
            double sum = 0;
            foreach (Position item in PositionList)
                sum += item.Y;
            return sum;
        }
        public static double sumXSquared()
        {
            double sum = 0;
            foreach (Position item in PositionList)
                sum += (item.X * item.X);
            return sum;
        }
        public static double sumXY()
        {
            double sum = 0;
            foreach (Position item in PositionList)
                sum += (item.X * item.Y);
            return sum;
        }

        public static int getN() => PositionList.Count;
    }
}
