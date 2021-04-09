using System;

namespace MathFormulas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            // Partially worked example
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The circumference is {circumference}");

            // Implementation for area here

            double area = (Math.PI * (intradius * intradius));
            Console.WriteLine($"The area is {area}");


            // Part 2
            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            double volume = ((4 / 3) * Math.PI * (intradius * intradius)) / 2;
            Console.WriteLine($"The volume is {volume}");


            // Part 3
            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
            double sideA = 10, sideB = 10, sideC = 10; // Initializing sides
            double p = (sideA + sideB + sideC) / 2; // Half of the circumference of a triangle
            area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            Console.WriteLine($"The area is {area}");


            // Part 4
            // For some reason this section compiles but there seems to be some sort of logic or runtime error as both solutions
            // end up being NaN every time
            Console.WriteLine("\nPart 4, solving a quadratic equation.");
            double positive_num = (-sideB + Math.Sqrt((sideB * sideB) - (4 * sideA * sideC)));
            double negative_num = (-sideB - Math.Sqrt((sideB * sideB) - (4 * sideA * sideC)));
            double denominator = 2 * sideA;

            Console.WriteLine($"The positive solution is {positive_num / denominator}");
            Console.WriteLine($"The negative solution is {negative_num / denominator}");
        }
    }
}
