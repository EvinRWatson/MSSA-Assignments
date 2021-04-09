using System;

namespace NumberConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the integer to convert: ");
            string n1 = Console.ReadLine();
            int number = int.Parse(n1);

            Console.Write("Please enter the base to convert from [2 | 8 | 10] :");
            string n2 = Console.ReadLine();
            int from = int.Parse(n2);

            Console.WriteLine($"Number: {number}, base : {from}");
            int result = 0;

            if(from == 10)
            {
                Console.WriteLine($"binary conversion is {Util.dec2bin(number)}" ) ; 
                Console.WriteLine($"octal conversion is {Util.dec2oct(number)}") ;
            }
            else if(from == 2)
            {
                Console.WriteLine($"decimal conversion is {Util.bin2dec(number)}") ;
                Console.WriteLine($"octal conversion is {Util.bin2oct(number)}" ) ;
            }
            else if(from == 8)
            {
                Console.WriteLine($"binary conversion is {Util.oct2bin(number)}");
                Console.WriteLine($"decimal conversion is {Util.oct2dec(number)}") ;
            }
            else
                Console.WriteLine("Error in base to convert from");
        }
    }
}
