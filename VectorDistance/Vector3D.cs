using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDistance
{
    public class Vector3D : Vector
    {
        Random rand = new Random();
        new public int x { get; }
        new public int y { get; }
        public int z { get; }

        public Vector3D()
        {
            this.x = rand.Next(100);
            this.y = rand.Next(100);
            this.z = rand.Next(100);
        }

        public Vector3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        new public void PrintVector()
        {
            Console.WriteLine($"({this.x}, {this.y}, {this.z})");
        }

        new public string getVector()
        {
            return ($"({this.x}, {this.y}, {this.z})");
        }

        public static double getDistance(Vector3D v1, Vector3D v2) => (Math.Sqrt(
                                                                              Math.Pow((v1.x - v2.x), 2) +
                                                                              Math.Pow((v1.y - v2.y), 2) +
                                                                              Math.Pow((v1.z - v2.z), 2)
                                                                              )
                                                                    );

        public static void PrintClosestVectors(Vector3D[] vectors)
        {
            Vector3D First = null;
            Vector3D Second = null;
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
