using System;
namespace MonteCarloMethod
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            double estPI = 0;
            if (args.Length == 0)
            {
                estPI = MonteCarlo(int.Parse(Console.ReadLine()));
            }
            else
                estPI = MonteCarlo(int.Parse(args[0]));

            Console.WriteLine($"Estimated PI: {estPI}");
            double variance = Math.Abs(Math.PI - estPI);
            Console.WriteLine($"Variance: {variance}");
        }

        public static double MonteCarlo(int numIterations)
        {
            Coordinates[] Coords = new Coordinates[numIterations];
            for (int i = 0; i < Coords.Length - 1; i++)
                Coords[i] = new Coordinates(rand);

            int counter = 0;
            for (int i = 0; i < Coords.Length - 1; i++)
                if (Hypotenuse(Coords[i]) <= 1)
                    counter++;

            double estimatedPI = ((double)counter / (double)Coords.Length) * 4;

            Console.WriteLine($"Estimated PI with {numIterations} Iterations:\t{estimatedPI}");
            return estimatedPI;
        }
        public static double Hypotenuse(Coordinates Coords) => Math.Sqrt(Math.Pow(Coords.getX(), 2) + Math.Pow(Coords.getY(), 2));
    }

    struct Coordinates
    {
        private double x, y;

        public Coordinates(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Coordinates(Random rand)
        {
            this.x = rand.NextDouble();
            this.y = rand.NextDouble();
        }
        public double getX() => x;
        public double getY() => y;

    }
}

//      Why do we multiply the value from step 5 above by 4?
//          To calculate all 4 quadrants of the circle
//      What do you observe in the output when running your program with parameters of increasing size?
//          The result gets more accurate
//      If you run the program multiple times with the same parameter, does the output remain the same? Why or why not?
//          Because it come up with new random coordinates everytime, ensuring it will always be different
//      Find a parameter that requires multiple seconds of run time. What is that parameter? How accurate is the estimated value of π?
//          100000000 with a small variance of 0.00016969358979324056
//      Research one other use of Monte-Carlo methods. Record it in your exercise submission and be prepared to discuss it in class.
//          Another use of the Monte Carlo method is raytracing in graphics applications such as video games by randomly tracing samples of possible light paths. One of the most accurate
//          3D graphics rendering methods in existence

