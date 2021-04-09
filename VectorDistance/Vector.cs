using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDistance
{
    public class Vector
    {
        Random rand = new Random();
        public int x { get; }
        public int y { get; }

        public Vector()
        {
            this.x = rand.Next(100);
            this.y = rand.Next(100);
        }
        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
        }

        public void PrintVector()
        {
            Console.WriteLine($"({this.x}, {this.y})");
        }

        public string getVector()
        {
            return ($"({this.x}, {this.y})");
        }
        public static double getDistance(Vector v1, Vector v2) => (Math.Sqrt(Math.Pow((v1.x - v2.x), 2) + Math.Pow((v1.y - v2.y), 2)));

        public static void PrintClosestVectors(Vector[] vectors)
        {
            Vector First = null;
            Vector Second = null;
            double MinimumDistance = double.MaxValue;


            for (int currentVector = 0; currentVector < vectors.Length; currentVector++)
            {
                for (int compareVector = 0; compareVector < vectors.Length; compareVector++)
                {
                    if (currentVector == compareVector)
                        continue;
                    if ((getDistance(vectors[currentVector], vectors[compareVector]) < MinimumDistance))
                    {
                        MinimumDistance = getDistance(vectors[currentVector], vectors[compareVector]);
                        First = vectors[currentVector];
                        Second = vectors[compareVector];
                    }
                }
            }

            Console.WriteLine($"Closest Points: {First.getVector()}, and {Second.getVector()}");
            Console.WriteLine($"Distance: {MinimumDistance}");
        }
    }
}
