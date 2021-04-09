using System;

namespace VectorDistance
{

    class Program
    {
        static void Main(string[] args)
        {
            //Note: If you select over 100 its most likely two points are the same and your shortest distance will be 0.
            //Mathematically it doesnt make too much sense I think it has to do with the Random class seed generation
            Console.WriteLine("Choose your sample size(integers only):\t");
            int sampleSize = int.Parse(Console.ReadLine());
            RunVector(sampleSize);
            RunVector3D(sampleSize);
        }

        static void RunVector(int size)
        {
            Vector[] vectors = new Vector[size];

            for (int i = 0; i < vectors.Length; i++)
            {
                vectors[i] = new Vector();
            }

            Console.WriteLine("Points:");
            for (int i = 0; i < vectors.Length; i++)
            {
                vectors[i].PrintVector();
            }
            
            Vector.PrintClosestVectors(vectors);
            Console.WriteLine();
        }
        static void RunVector3D(int size)
        {
            Vector3D[] vectors = new Vector3D[size];

            for (int i = 0; i < vectors.Length; i++)
            {
                vectors[i] = new Vector3D();
            }

            Console.WriteLine("Points:");
            for (int i = 0; i < vectors.Length; i++)
            {
                vectors[i].PrintVector();
            }

            Vector3D.PrintClosestVectors(vectors);
            Console.WriteLine();
        }
    }
}


